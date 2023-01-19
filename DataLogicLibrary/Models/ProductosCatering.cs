using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ProductosCatering
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Titulo { get; set; }

    public int EstadoId { get; set; }

    public virtual ICollection<ProductosCateringItem> ProductosCateringItems { get; } = new List<ProductosCateringItem>();

    public virtual ICollection<TipoCateringTiempoProductoItem> TipoCateringTiempoProductoItems { get; } = new List<TipoCateringTiempoProductoItem>();
}
