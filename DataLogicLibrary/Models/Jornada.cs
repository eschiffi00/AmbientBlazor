using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Jornada
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<CostoSalone> CostoSalones { get; } = new List<CostoSalone>();

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();
}
