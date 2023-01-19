using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CategoriasItem
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? CategoriaItemPadreId { get; set; }

    public int EstadoId { get; set; }

    public virtual ICollection<Familia> Familia { get; } = new List<Familia>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<Items2> Items2s { get; } = new List<Items2>();

    public virtual ICollection<TipoBarraCategoriaItem> TipoBarraCategoriaItems { get; } = new List<TipoBarraCategoriaItem>();

    public virtual ICollection<TipoCateringTiempoProductoItem> TipoCateringTiempoProductoItems { get; } = new List<TipoCateringTiempoProductoItem>();
}
