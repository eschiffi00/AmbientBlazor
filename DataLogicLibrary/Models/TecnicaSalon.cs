using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TecnicaSalon
{
    public int Id { get; set; }

    public int ProveedorId { get; set; }

    public int LocacionId { get; set; }

    public int SectorId { get; set; }

    public virtual Locacione Locacion { get; set; } = null!;

    public virtual Proveedore Proveedor { get; set; } = null!;
}
