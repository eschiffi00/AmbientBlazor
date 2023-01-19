using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoTecnica
{
    public int Id { get; set; }

    public int SegmentoId { get; set; }

    public int TipoServicioId { get; set; }

    public double Precio { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public string Dia { get; set; } = null!;

    public int ProveedorId { get; set; }

    public double ValorMas5PorCiento { get; set; }

    public double ValorMenos5PorCiento { get; set; }

    public double ValorMenos10PorCiento { get; set; }

    public double? Costo { get; set; }

    public int? SectorId { get; set; }

    public virtual Segmento Segmento { get; set; } = null!;

    public virtual TipoServicio TipoServicio { get; set; } = null!;
}
