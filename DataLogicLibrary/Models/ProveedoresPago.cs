using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ProveedoresPago
{
    public int NroPresupuesto { get; set; }

    public long NroFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public DateTime? FechaSena { get; set; }

    public string TipoComprobante { get; set; } = null!;

    public string CuentaContable { get; set; } = null!;

    public DateTime? FechaEvento { get; set; }

    public string UnidadNegocio { get; set; } = null!;

    public double? Costo { get; set; }

    public double ValorNetoFactura { get; set; }

    public double ValorDetalleFactura { get; set; }

    public double? ImportePago { get; set; }

    public string? Cuit { get; set; }

    public string Proveedor { get; set; } = null!;

    public DateTime FechaPago { get; set; }

    public string? FormaPago { get; set; }
}
