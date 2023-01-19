using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioPedido
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public int ProveedorId { get; set; }

    public int EstadoId { get; set; }

    public DateTime CreateFecha { get; set; }

    public DateTime? UpdateFecha { get; set; }

    public DateTime? DeleteFecha { get; set; }

    public bool? Delete { get; set; }

    public virtual ICollection<InventarioRequerimientoDetalle> InventarioRequerimientoDetalles { get; } = new List<InventarioRequerimientoDetalle>();
}
