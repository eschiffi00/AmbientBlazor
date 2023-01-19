using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoBarraCategoriaItem
{
    public int Id { get; set; }

    public int TipoBarraId { get; set; }

    public int? CategoriaItemId { get; set; }

    public int? ItemId { get; set; }

    public int EstadoId { get; set; }

    public virtual CategoriasItem? CategoriaItem { get; set; }

    public virtual TiposBarra TipoBarra { get; set; } = null!;
}
