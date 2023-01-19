using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ComprobantesPagado
{
    public int Id { get; set; }

    public int ComprobanteProveedorDetalleId { get; set; }

    public int? NroPresupuesto { get; set; }

    public int? TipoMovimiento { get; set; }

    public string? Tmdescripcion { get; set; }

    public double? MontoPagado { get; set; }
}
