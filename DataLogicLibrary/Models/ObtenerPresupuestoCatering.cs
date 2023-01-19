using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerPresupuestoCatering
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int ExperienciaId { get; set; }

    public int ProveedorId { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioMas5 { get; set; }

    public double PrecioMenos5 { get; set; }

    public double PrecioMenos10 { get; set; }

    public byte[]? Adjunto { get; set; }

    public string? AdjuntoExtension { get; set; }

    public double? CostoLogistica { get; set; }

    public double? CostoCanon { get; set; }

    public double? ValorSeleccionado { get; set; }

    public double? Descuentos { get; set; }

    public string Descripcion { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;
}
