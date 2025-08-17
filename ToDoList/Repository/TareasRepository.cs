using ToDoList.Models;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;

namespace ToDoList.Repository
{
    public class TareasRepository : ITareasRepository
    {
        private readonly AppDbContext _context;

        public TareasRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarea>> GetAllAsync()
        {
            return await _context.Tareas.ToListAsync();
        }

        public async Task<Tarea?> GetByIdAsync(Guid id)
        {
            return await _context.Tareas.FindAsync(id);
        }

        public async Task AddAsync(Tarea tarea)
        {
            await _context.Tareas.AddAsync(tarea);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tarea tarea)
        {
            _context.Tareas.Update(tarea);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var tarea = await _context.Tareas.FindAsync(id);
            if (tarea != null)
            {
                _context.Tareas.Remove(tarea);
                await _context.SaveChangesAsync();
            }
        }

    }
}
