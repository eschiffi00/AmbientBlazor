using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Items2
{
    public int Id { get; set; }

    public string Detalle { get; set; } = null!;

    public int CategoriaItemId { get; set; }

    public double Costo { get; set; }

    public double Margen { get; set; }

    public double Precio { get; set; }

    public int? EstadoId { get; set; }

    public int? ItemDetalleId { get; set; }

    public int? CuentaId { get; set; }

    public int? DepositoId { get; set; }

    public string? TipoItem { get; set; }

    public int? NombreFantasiaId { get; set; }

    public virtual CategoriasItem CategoriaItem { get; set; } = null!;
}
