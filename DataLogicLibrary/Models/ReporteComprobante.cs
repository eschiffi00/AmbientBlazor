using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ReporteComprobante
{
    public int Id { get; set; }

    public long NroComprobante { get; set; }

    public DateTime Fecha { get; set; }

    public double? MontoFactura { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? RazonSocial { get; set; }

    public string Cuenta { get; set; } = null!;

    public double Neto { get; set; }

    public string TipoImpuesto { get; set; } = null!;

    public double Impuesto { get; set; }

    public double Impuestointerno { get; set; }

    public string? FormadePago { get; set; }

    public string Cc { get; set; } = null!;

    public string Leyenda { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public int TipoMoviemientoId { get; set; }

    public int? PresupuestoId { get; set; }
}
