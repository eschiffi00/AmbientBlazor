using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class GastosporPresupuesto
{
    public long NroComprobante { get; set; }

    public string Tipomovimiento { get; set; } = null!;

    public string Centrocosto { get; set; } = null!;

    public double Importe { get; set; }

    public string? Impuesto { get; set; }

    public double ValorImpuesto { get; set; }

    public double ValorImpuestoInterno { get; set; }

    public int? PresupuestoId { get; set; }

    public string? RazonSocial { get; set; }

    public string? ApellidoNombre { get; set; }

    public string Leyenda { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateTime Fecha { get; set; }
}
