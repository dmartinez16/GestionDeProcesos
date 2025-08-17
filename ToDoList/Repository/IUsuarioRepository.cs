using ToDoList.Models;

namespace ToDoList.Repository
{
    /// <summary>
    /// Interfaz para el control de datos del usuario
    /// </summary>
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos los usuarios registrados
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Usuario>> GetAllAsync();

        /// <summary>
        /// Realiza la busqueda de un usuario en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Usuario?> GetByIdAsync(Guid id);

        /// <summary>
        /// Registra 1 usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task AddAsync(Usuario usuario);

        /// <summary>
        /// Modifica 1 usuario en especifico
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        Task UpdateAsync(Usuario usuario);

        /// <summary>
        /// Elimina 1 usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(Guid id);
    }
}
