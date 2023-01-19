using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Tiempo
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte[]? ImagenMarcoSuperior { get; set; }

    public string? ImagenMarcoSuperiorExtension { get; set; }

    public int? Orden { get; set; }

    public virtual ICollection<TipoCateringTiempoProductoItem> TipoCateringTiempoProductoItems { get; } = new List<TipoCateringTiempoProductoItem>();
}
