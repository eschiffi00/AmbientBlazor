using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ComprobantesProveedoresDetalle
{
    public int Id { get; set; }

    public int ComprobanteProveedorId { get; set; }

    public int TipoMoviemientoId { get; set; }

    public int CentroCostoId { get; set; }

    public double Importe { get; set; }

    public string Descripcion { get; set; } = null!;

    public double Cantidad { get; set; }

    public int? TipoImpuestoId { get; set; }

    public double? ValorImpuesto { get; set; }

    public double? ValorImpuestoInterno { get; set; }

    public int? PresupuestoId { get; set; }

    public int? UnidadNegocioId { get; set; }

    public int? DegustacionId { get; set; }

    public virtual CentroCosto CentroCosto { get; set; } = null!;

    public virtual ComprobantesProveedore ComprobanteProveedor { get; set; } = null!;

    public virtual Presupuesto? Presupuesto { get; set; }

    public virtual Impuesto? TipoImpuesto { get; set; }

    public virtual TipoMovimiento TipoMoviemiento { get; set; } = null!;

    public virtual UnidadesNegocio? UnidadNegocio { get; set; }
}
