using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerPresupuestoBarra
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int TipoBarraId { get; set; }

    public string SalonInOut { get; set; } = null!;

    public int ProveedorId { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioMas5 { get; set; }

    public double PrecioMenos5 { get; set; }

    public double PrecioMenos10 { get; set; }

    public byte[]? Adjunto { get; set; }

    public string? AdjuntoExtension { get; set; }

    public double? ValorSeleccionado { get; set; }

    public double? Descuentos { get; set; }

    public string Descripcion { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public double? CostoCanon { get; set; }

    public double? CostoLogistica { get; set; }
}
