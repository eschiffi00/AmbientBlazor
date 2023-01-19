using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Ratio : TEntityBase
{
    //public int Id { get; set; }

    public int ItemId { get; set; }

    public string ExperienciaBarra { get; set; } = null!;

    public string TipoRatio { get; set; } = null!;

    public double BaseRatio { get; set; }

    public double ValorRatio { get; set; }

    public double TopeRatio { get; set; }

    public bool? Isla { get; set; }

    public bool Adultos { get; set; }

    public bool Menores3 { get; set; }

    public bool Menores3y8 { get; set; }

    public bool Adolescentes { get; set; }

    public bool FijoRatio { get; set; }

    public int EstadoId { get; set; }

    public int? ItemRatioId { get; set; }

    public int? ProductoRatioId { get; set; }

    public int? CategoriaRatioId { get; set; }
}
