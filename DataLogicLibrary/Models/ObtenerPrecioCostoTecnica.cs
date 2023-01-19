using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerPrecioCostoTecnica
{
    public int Id { get; set; }

    public string Servicio { get; set; } = null!;

    public string Segmento { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public int Anio { get; set; }

    public int Mes { get; set; }

    public string Dia { get; set; } = null!;

    public double Precio { get; set; }

    public double? Costo { get; set; }
}
