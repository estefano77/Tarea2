using Microsoft.AspNetCore.Components;

namespace Tarea1.Pages
{
    partial class Contenedor
    {
        [Parameter] public string Titulo { get; set; } = "";
        [Parameter] public RenderFragment? Codigo { get; set; }
        [Parameter] public RenderFragment? Foot { get; set; }

        [Parameter] public EventCallback Aceptar { get; set; }
        [Parameter] public EventCallback Cancelar { get; set; }

    }
}
