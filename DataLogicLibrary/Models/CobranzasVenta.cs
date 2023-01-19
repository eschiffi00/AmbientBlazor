using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CobranzasVenta
{
    public int PresupuestoId { get; set; }

    public double? Importe { get; set; }

    public string? NroRecibo { get; set; }

    public string? Concepto { get; set; }

    public DateTime FechaPago { get; set; }

    public string Descripcion { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string? FormaPago { get; set; }

    public DateTime? FechaEvento { get; set; }

    public double? Totalpresupuestosinindexacion { get; set; }

    public double? Indexacion { get; set; }

    public string? TipoIndexacion { get; set; }
}
