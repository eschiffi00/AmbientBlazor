using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Bloqueo
{
    public int BloqueoId { get; set; }

    public int RolId { get; set; }

    public int FormId { get; set; }

    public string Control { get; set; } = null!;

    public int EstadoId { get; set; }

    public virtual Form Form { get; set; } = null!;

    public virtual Rol Rol { get; set; } = null!;
}
