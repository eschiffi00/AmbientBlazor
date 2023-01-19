using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioRequerimientoDetalle
{
    public int Id { get; set; }

    public int? PresupuestoId { get; set; }

    public int? RequerimientoId { get; set; }

    public int? PedidoId { get; set; }

    public int ProductoId { get; set; }

    public double Cantidad { get; set; }

    public int UnidadId { get; set; }

    public double? Costo { get; set; }

    public DateTime CreateFecha { get; set; }

    public DateTime? UpdateFecha { get; set; }

    public DateTime? DeleteFecha { get; set; }

    public bool? Delete { get; set; }

    public virtual InventarioPedido? Pedido { get; set; }

    public virtual InventarioRequerimiento? Requerimiento { get; set; }
}
