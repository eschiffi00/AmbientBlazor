using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class UnidadesNegociosProveedore
{
    public int Id { get; set; }

    public int UnidadNegocioId { get; set; }

    public int ProveedorId { get; set; }

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual UnidadesNegocio UnidadNegocio { get; set; } = null!;
}
