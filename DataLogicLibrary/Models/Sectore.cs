using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Sectore
{
    public int Id { get; set; }

    public int LocacionId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CostoSalone> CostoSalones { get; } = new List<CostoSalone>();

    public virtual Locacione Locacion { get; set; } = null!;
}
