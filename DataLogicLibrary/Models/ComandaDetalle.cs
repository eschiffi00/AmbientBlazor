using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ComandaDetalle
{
    public int Id { get; set; }

    public int ComandaId { get; set; }

    public string Clave { get; set; } = null!;

    public int? ItemId { get; set; }

    public double? Cantidad { get; set; }

    public int? EsItem { get; set; }

    public int? EsProducto { get; set; }

    public int? EsAdicional { get; set; }

    public int? Orden { get; set; }
}
