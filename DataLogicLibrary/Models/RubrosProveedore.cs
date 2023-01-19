using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class RubrosProveedore
{
    public int Id { get; set; }

    public int RubroId { get; set; }

    public int ProveedorId { get; set; }

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual Rubro Rubro { get; set; } = null!;
}
