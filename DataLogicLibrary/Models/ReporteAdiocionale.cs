using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ReporteAdiocionale
{
    public int Nroevento { get; set; }

    public int Nropresupuesto { get; set; }

    public string? Fechaevento { get; set; }

    public string Rubro { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? Cantidad { get; set; }

    public double? ValorAdicional { get; set; }
}
