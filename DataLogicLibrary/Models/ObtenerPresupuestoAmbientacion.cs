using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerPresupuestoAmbientacion
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int SectorId { get; set; }

    public int CaracteristicaId { get; set; }

    public int SegmentoId { get; set; }

    public int CategoriaId { get; set; }

    public int ProveedorIr { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioMas5 { get; set; }

    public double PrecioMenos5 { get; set; }

    public double PrecioMenos10 { get; set; }

    public byte[]? Adjunto { get; set; }

    public string? AdjuntoExtension { get; set; }

    public double? ValorSeleccionado { get; set; }

    public double? Descuentos { get; set; }

    public string Segmento { get; set; } = null!;

    public string Caracteristicas { get; set; } = null!;

    public string Sector { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;
}
