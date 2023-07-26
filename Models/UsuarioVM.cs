using System.ComponentModel.DataAnnotations;

namespace Tarea1.Models
{
    public class UsuarioVM
    {
        [Required(ErrorMessage= "Rut no puede estar en blanco.")]
        [RegularExpression(@"[0-9]{8}[/-]{1}[0-9kK]{1}", ErrorMessage ="Rut debe tener formato 99999999-X")]
        public  string Rut { get; set; }
        [Required(ErrorMessage = "Nombre no puede estar en blanco.")]
        [MaxLength(60, ErrorMessage = "Sólo 60 caracteres para el Nombre")]
        public string  ? Nombre { get; set; }
        [Required(ErrorMessage = "Fecha Nacimiento no puede estar en blanco.")]
        public DateTime Fecha_nacimiento { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Usuario no puede estar en blanco.")]
        [MaxLength(10, ErrorMessage = "Sólo 10 caracteres para el Usuario")]
        public string ? Usuario { get; set; }
        [Required(ErrorMessage = "Contraseña no puede estar en blanco.")]
        [MaxLength(10, ErrorMessage = "Sólo 10 caracteres para la Contraseña")]
        [RegularExpression(@"[A-Z]{1}[a-z-A-Z]{9}", ErrorMessage = "La primera letra debe ser mayúscula")]
        public string ? Contraseña { get; set; }

    }
}
