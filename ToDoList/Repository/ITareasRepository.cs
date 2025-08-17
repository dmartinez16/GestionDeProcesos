using ToDoList.Models;

namespace ToDoList.Repository
{
    /// <summary>
    /// Interfaz para el control de datos del Tareas
    /// </summary>
    public interface ITareasRepository
    {
        /// <summary>
        /// Lista todos las tareas registrados
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Tarea>> GetAllAsync();

        /// <summary>
        /// Realiza la busqueda de un tarea en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Tarea?> GetByIdAsync(Guid id);

        /// <summary>
        /// Registra 1 tarea
        /// </summary>
        /// <param name="tarea"></param>
        /// <returns></returns>
        Task AddAsync(Tarea tarea);

        /// <summary>
        /// Modifica 1 tarea en especifico
        /// </summary>
        /// <param name="tarea"></param>
        /// <returns></returns>
        Task UpdateAsync(Tarea tarea);

        /// <summary>
        /// Elimina 1 tarea
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
    }
}
