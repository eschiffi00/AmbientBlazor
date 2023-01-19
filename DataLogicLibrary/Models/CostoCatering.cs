using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoCatering
{
    public int Id { get; set; }

    public int TipoCateringId { get; set; }

    public int CantidadPersonas { get; set; }

    public double Precio { get; set; }

    public double ValorMas5PorCiento { get; set; }

    public double ValorMenos5PorCiento { get; set; }

    public double ValorMenos10PorCiento { get; set; }

    public double? Costo { get; set; }

    public int? ProveedorId { get; set; }

    public virtual TipoCatering TipoCatering { get; set; } = null!;
}
