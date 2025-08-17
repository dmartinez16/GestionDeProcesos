using ToDoList.Data;
using Microsoft.EntityFrameworkCore;
using ToDoList.Repository;

//Contenedor
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//Cadena de conexión
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "DefaultConnection" )
    )
);

//Repositorios 
builder.Services.AddScoped<ITareasRepository, TareasRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
