using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ProveedoresRetencione
{
    public int Id { get; set; }

    public int ProveedorId { get; set; }

    public int TablaRetencionId { get; set; }

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual TablaRetencione TablaRetencion { get; set; } = null!;
}
