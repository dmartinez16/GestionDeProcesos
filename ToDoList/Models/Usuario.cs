namespace ToDoList.Models
{
    /// <summary>
    /// Entidad con propiedades para el objeto Usuario
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nombre de la persona registrada
        /// </summary>
        public string Nombre { get; set; } = string.Empty;

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; } = string.Empty;
    }
}
