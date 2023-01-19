using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioUnidade
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string DescripcionCorta { get; set; } = null!;

    public virtual ICollection<InventarioProducto> InventarioProductoUnidadPresentacions { get; } = new List<InventarioProducto>();

    public virtual ICollection<InventarioProducto> InventarioProductoUnidads { get; } = new List<InventarioProducto>();

    public virtual ICollection<InventarioReceta> InventarioReceta { get; } = new List<InventarioReceta>();

    public virtual ICollection<InventarioUnidadesConversion> InventarioUnidadesConversionUnidadDestinos { get; } = new List<InventarioUnidadesConversion>();

    public virtual ICollection<InventarioUnidadesConversion> InventarioUnidadesConversionUnidadOriginals { get; } = new List<InventarioUnidadesConversion>();
}
