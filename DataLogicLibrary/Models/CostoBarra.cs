using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoBarra
{
    public int Id { get; set; }

    public int TipoBarraId { get; set; }

    public double Precios { get; set; }

    public int CantidadPersonas { get; set; }

    public double ValorMas5PorCiento { get; set; }

    public double ValorMenos5PorCiento { get; set; }

    public double ValorMenos10PorCiento { get; set; }

    public double? Costo { get; set; }

    public int? ProveedorId { get; set; }

    public virtual TiposBarra TipoBarra { get; set; } = null!;
}
