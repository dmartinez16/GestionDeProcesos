using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data
{
    /// <summary>
    /// Gestion conexión con base de datos
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
       
        }

        /// <summary>
        /// Tabla Usuarios
        /// </summary>
        public DbSet<Usuario> Usuarios { get; set; }

        /// <summary>
        /// Tabla Tareas
        /// </summary>
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tarea>().HasKey(t => t.Id);
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);

        }
    }
}
