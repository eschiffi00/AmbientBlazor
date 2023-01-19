using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ProveedoresFormasdePago
{
    public int Id { get; set; }

    public int ProveedorId { get; set; }

    public int FormadePagoId { get; set; }

    public virtual FormasdePago FormadePago { get; set; } = null!;

    public virtual Proveedore Proveedor { get; set; } = null!;
}
