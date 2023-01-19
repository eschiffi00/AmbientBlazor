using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class AdicionalesItem
{
    public int Id { get; set; }

    public int AdicionalId { get; set; }

    public int ItemId { get; set; }

    public virtual Adicionale Adicional { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;
}
