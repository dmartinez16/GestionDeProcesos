using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Repository;

namespace ToDoList.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var usuarios = await _usuarioRepository.GetAllAsync();
            return View(usuarios);
        }

        // GET: Usuarios/Details/{id}
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();

            var usuario = await _usuarioRepository.GetByIdAsync(id.Value);
            if (usuario == null) return NotFound();

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Email")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                await _usuarioRepository.AddAsync(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/{id}
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();

            var usuario = await _usuarioRepository.GetByIdAsync(id.Value);
            if (usuario == null) return NotFound();

            return View(usuario);
        }

        // POST: Usuarios/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nombre,Email")] Usuario usuario)
        {
            if (id != usuario.Id) return NotFound();

            if (ModelState.IsValid)
            {
                await _usuarioRepository.UpdateAsync(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/{id}
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) return NotFound();

            var usuario = await _usuarioRepository.GetByIdAsync(id.Value);
            if (usuario == null) return NotFound();

            return View(usuario);
        }

        // POST: Usuarios/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _usuarioRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
