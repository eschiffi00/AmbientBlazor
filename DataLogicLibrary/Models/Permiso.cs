using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Permiso
{
    public int PermisoId { get; set; }

    public int RolId { get; set; }

    public int FormId { get; set; }

    public int EstadoId { get; set; }

    public virtual Form Form { get; set; } = null!;

    public virtual Rol Rol { get; set; } = null!;
}
