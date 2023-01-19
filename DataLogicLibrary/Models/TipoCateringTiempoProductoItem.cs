using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoCateringTiempoProductoItem
{
    public int Id { get; set; }

    public int TipoCateringId { get; set; }

    public int TiempoId { get; set; }

    public int? ProductoCateringId { get; set; }

    public int? CategoriaItemId { get; set; }

    public int? ItemId { get; set; }

    public int EstadoId { get; set; }

    public virtual CategoriasItem? CategoriaItem { get; set; }

    public virtual ProductosCatering? ProductoCatering { get; set; }

    public virtual Tiempo Tiempo { get; set; } = null!;

    public virtual TipoCatering TipoCatering { get; set; } = null!;
}
