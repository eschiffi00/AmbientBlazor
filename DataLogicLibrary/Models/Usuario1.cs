using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Usuario1
{
    public int EmpleadoId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? PerfilId { get; set; }

    public int EstadoId { get; set; }

    public string? CodigoSeguridad { get; set; }

    public string? RutaCodigoSeguridad { get; set; }

    public bool HabilitarCambioPassword { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual Perfile? Perfil { get; set; }
}
