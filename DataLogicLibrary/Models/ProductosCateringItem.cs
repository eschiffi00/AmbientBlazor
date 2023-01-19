using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ProductosCateringItem
{
    public int Id { get; set; }

    public int ProductoCateringId { get; set; }

    public int ItemId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ProductosCatering ProductoCatering { get; set; } = null!;
}
