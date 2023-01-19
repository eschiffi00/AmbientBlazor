using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ItemDetalle
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public int? DetalleItemId { get; set; }

    public int? EstadoId { get; set; }
}
