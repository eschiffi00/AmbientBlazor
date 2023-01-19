using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Comisione
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Precio { get; set; }

    public int? UnidadNegocioId { get; set; }

    public double Porcentaje { get; set; }

    public double? PorcentajeAdicional { get; set; }
}
