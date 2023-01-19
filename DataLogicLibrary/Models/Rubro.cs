using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Rubro
{
    public int RubroId { get; set; }

    public string? Descripcion { get; set; }

    public string? LetraCodigo { get; set; }

    public virtual ICollection<CodigoPorRubro> CodigoPorRubros { get; } = new List<CodigoPorRubro>();

    public virtual ICollection<InventarioProducto> InventarioProductos { get; } = new List<InventarioProducto>();

    public virtual ICollection<RubrosProveedore> RubrosProveedores { get; } = new List<RubrosProveedore>();
}
