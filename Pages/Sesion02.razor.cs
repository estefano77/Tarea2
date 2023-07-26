using Tarea1.Models;

namespace Tarea1.Pages
{
    public partial class Sesion02
    {
        private UsuarioVM ModelUsuario { get; set; } = new();

        private void Aceptar()
        {

        }

        private void Cancelar()
        {
            ModelUsuario = new();
        }
    }
}
