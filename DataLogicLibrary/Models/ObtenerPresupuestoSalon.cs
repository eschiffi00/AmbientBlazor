using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerPresupuestoSalon
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int LocacionId { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioMas5 { get; set; }

    public double PrecioMenos5 { get; set; }

    public double PrecioMenos10 { get; set; }

    public byte[]? Adjunto { get; set; }

    public string? AdjuntoExtension { get; set; }

    public double? ValorSeleccionado { get; set; }

    public double? Descuentos { get; set; }

    public string Locacion { get; set; } = null!;
}
