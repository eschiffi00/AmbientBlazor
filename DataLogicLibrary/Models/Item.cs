using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Item
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

    public virtual ICollection<AdicionalesItem> AdicionalesItems { get; } = new List<AdicionalesItem>();

    public virtual CategoriasItem CategoriaItem { get; set; } = null!;

    public virtual ICollection<ProductosCateringItem> ProductosCateringItems { get; } = new List<ProductosCateringItem>();
}
