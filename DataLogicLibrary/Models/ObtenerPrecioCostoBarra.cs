using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerPrecioCostoBarra
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int CantidadPersonas { get; set; }

    public double Precios { get; set; }

    public double? Costo { get; set; }
}
