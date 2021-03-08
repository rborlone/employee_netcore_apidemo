using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Nombre solo puede tener 100 caracteres")]
        public string Nombre { get; set; }
        [MaxLength(100, ErrorMessage = "La direccion puede tener 100 caracteres")]
        public string Direccion { get; set; }
                [MaxLength(15, ErrorMessage = "El numero de telefono puede tener 15 caracteres")]
        public string Telefono { get; set; }
    }
}