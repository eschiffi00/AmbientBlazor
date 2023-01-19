using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Form
{
    public int FormId { get; set; }

    public string Nombre { get; set; } = null!;

    public int EstadoId { get; set; }

    public virtual ICollection<Bloqueo> Bloqueos { get; } = new List<Bloqueo>();

    public virtual ICollection<Permiso> Permisos { get; } = new List<Permiso>();
}
