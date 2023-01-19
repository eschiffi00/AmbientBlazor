using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class PresupuestoDetalle
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int UnidadNegocioId { get; set; }

    public int? ProveedorId { get; set; }

    public int? ServicioId { get; set; }

    public int? LocacionId { get; set; }

    public int ProductoId { get; set; }

    public double PrecioItem { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioMas5 { get; set; }

    public double PrecioMenos5 { get; set; }

    public double PrecioMenos10 { get; set; }

    public string CodigoItem { get; set; } = null!;

    public double? Descuentos { get; set; }

    public double? Incremento { get; set; }

    public string PrecioSeleccionado { get; set; } = null!;

    public double PorcentajeComision { get; set; }

    public double ValorSeleccionado { get; set; }

    public double Comision { get; set; }

    public int? CantidadAdicional { get; set; }

    public double? Costo { get; set; }

    public double? Cannon { get; set; }

    public int? TipoLogisticaId { get; set; }

    public int? LocalidadId { get; set; }

    public int? CantInvitadosLogistica { get; set; }

    public double? Logistica { get; set; }

    public double? UsoCocina { get; set; }

    public double? ValorIntermediario { get; set; }

    public double? CostoSillas { get; set; }

    public double? CostoMesas { get; set; }

    public double? PrecioSillas { get; set; }

    public double? PrecioMesas { get; set; }

    public int? Version { get; set; }

    public int? EstadoId { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public string? Comentario { get; set; }

    public string? ComentarioProveedor { get; set; }

    public DateTime? FechaCobroItem { get; set; }

    public bool? EstadoProveedor { get; set; }

    public bool AnuloCanon { get; set; }

    public DateTime? FechaCreate { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public bool? Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public double Royalty { get; set; }

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
