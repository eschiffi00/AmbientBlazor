using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioReceta
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public int IngredienteId { get; set; }

    public int UnidadId { get; set; }

    public double Cantidad { get; set; }

    public int Porciones { get; set; }

    public virtual InventarioProducto Ingrediente { get; set; } = null!;

    public virtual InventarioProducto Producto { get; set; } = null!;

    public virtual InventarioUnidade Unidad { get; set; } = null!;
}
