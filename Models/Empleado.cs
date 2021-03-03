using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Nombre solo puede tener 50 caracteres")]
        public string Nombre { get; set; }
    }
}