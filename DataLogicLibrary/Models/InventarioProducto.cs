using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioProducto
{
    public int Id { get; set; }

    public int RubroId { get; set; }

    public string Codigo { get; set; } = null!;

    public string? CodigoBarra { get; set; }

    public string Descripcion { get; set; } = null!;

    public double CantidadNominal { get; set; }

    public double Cantidad { get; set; }

    public double Costo { get; set; }

    public int UnidadId { get; set; }

    public int UnidadPresentacionId { get; set; }

    public int UnidadMedidaConversionId { get; set; }

    public int? TipoMovimientoId { get; set; }

    public int? CentroCostoId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool Delete { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<InventarioMovimientoProducto> InventarioMovimientoProductos { get; } = new List<InventarioMovimientoProducto>();

    public virtual ICollection<InventarioProductoDeposito> InventarioProductoDepositos { get; } = new List<InventarioProductoDeposito>();

    public virtual ICollection<InventarioReceta> InventarioRecetaIngredientes { get; } = new List<InventarioReceta>();

    public virtual ICollection<InventarioReceta> InventarioRecetaProductos { get; } = new List<InventarioReceta>();

    public virtual Rubro Rubro { get; set; } = null!;

    public virtual InventarioUnidade Unidad { get; set; } = null!;

    public virtual InventarioUnidadesConversion UnidadMedidaConversion { get; set; } = null!;

    public virtual InventarioUnidade UnidadPresentacion { get; set; } = null!;
}
