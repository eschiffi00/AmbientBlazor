using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoAmbientacion
{
    public int Id { get; set; }

    public int CategoriaId { get; set; }

    public int ProveedorId { get; set; }

    public double Precio { get; set; }

    public double ValorMas5PorCiento { get; set; }

    public double ValorMenos5PorCiento { get; set; }

    public double ValorMenos10PorCiento { get; set; }

    public int CantidadInvitados { get; set; }

    public double? Costo { get; set; }

    public int? SectorId { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;
}
