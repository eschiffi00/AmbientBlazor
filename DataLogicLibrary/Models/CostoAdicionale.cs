using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoAdicionale
{
    public int Id { get; set; }

    public int AdicionalId { get; set; }

    public int CantidadPersonas { get; set; }

    public double Precio { get; set; }

    public double ValorMas5PorCiento { get; set; }

    public double ValorMenos5PorCiento { get; set; }

    public double ValorMenos10PorCiento { get; set; }

    public double? Costo { get; set; }

    public int? Locacion { get; set; }

    public int? ProveedorId { get; set; }

    public virtual Adicionale Adicional { get; set; } = null!;
}
