using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Indexacion
{
    public int Id { get; set; }

    public double ValorIndexacion { get; set; }

    public string TipoIndexacion { get; set; } = null!;

    public DateTime? FechaVencimiento { get; set; }
}
