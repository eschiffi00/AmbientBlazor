using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class LocacionesValorAnio
{
    public int Id { get; set; }

    public int LocacionId { get; set; }

    public int Anio { get; set; }

    public double Costo { get; set; }

    public virtual Locacione Locacion { get; set; } = null!;
}
