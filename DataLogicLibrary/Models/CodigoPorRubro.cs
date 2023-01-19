using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CodigoPorRubro
{
    public int Id { get; set; }

    public int RubroId { get; set; }

    public int Codigo { get; set; }

    public virtual Rubro Rubro { get; set; } = null!;
}
