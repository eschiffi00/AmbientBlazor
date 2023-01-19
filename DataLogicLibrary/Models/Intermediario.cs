using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Intermediario
{
    public int Id { get; set; }

    public int ProveedorId { get; set; }

    public int UnidadNegocioId { get; set; }

    public int LocacionId { get; set; }

    public string TipoComision { get; set; } = null!;

    public double? Porcentaje { get; set; }

    public double? Valor { get; set; }

    public virtual Locacione Locacion { get; set; } = null!;

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual UnidadesNegocio UnidadNegocio { get; set; } = null!;
}
