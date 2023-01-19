using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerUsuario
{
    public string? ApellidoNombre { get; set; }

    public string UserName { get; set; } = null!;

    public string? Mail { get; set; }

    public string Nombre { get; set; } = null!;

    public int EstadoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int EmpleadoId { get; set; }

    public int Id { get; set; }
}
