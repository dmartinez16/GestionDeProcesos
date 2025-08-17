using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    /// <summary>
    /// Entidad con propiedades para objeto Tarea
    /// </summary>
    public class Tarea
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public Guid Id { get; set; }
    
        /// <summary>
        /// Nombre que representa la actividad de manera global
        /// </summary>
        public string Titulo { get; set; } = string.Empty;

        /// <summary>
        /// Detalle de la actividad
        /// </summary>
        public string Descripcion { get; set; } = string.Empty;

        /// <summary>
        /// Estado en el que se encuentra la actividad
        /// </summary>
        [RegularExpression("Pendiente|En Progreso|Completada")]
        public string Estado {  get; set; } = string.Empty;

        /// <summary>
        /// Fecha de registro
        /// </summary>
        public DateTime FecCreacion {  get; set; } = DateTime.Now;
    
        /// <summary>
        /// Identificador del responsable para la tarea
        /// </summary>
        public Guid ResponsableId { get; set; }

        /// <summary>
        /// Objeto Usuario del responsable relacionado a la tarea
        /// </summary>
       
        public Usuario? Responsable { get; set; } 

    }
}
