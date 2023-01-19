using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TablaRetencione
{
    public int Id { get; set; }

    public string Concepto { get; set; } = null!;

    public double? PorcentajeInscripto { get; set; }

    public double? PorcentajeNoInscripto { get; set; }

    public double? ValorMaximoaRetenerInscriptos { get; set; }

    public virtual ICollection<ProveedoresRetencione> ProveedoresRetenciones { get; } = new List<ProveedoresRetencione>();
}
