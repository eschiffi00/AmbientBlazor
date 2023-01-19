using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioUnidadesConversion
{
    public int Id { get; set; }

    public int UnidadOriginalId { get; set; }

    public int UnidadDestinoId { get; set; }

    public double Cantidad { get; set; }

    public virtual ICollection<InventarioProducto> InventarioProductos { get; } = new List<InventarioProducto>();

    public virtual InventarioUnidade UnidadDestino { get; set; } = null!;

    public virtual InventarioUnidade UnidadOriginal { get; set; } = null!;
}
