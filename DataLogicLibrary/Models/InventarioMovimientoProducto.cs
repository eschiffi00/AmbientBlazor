using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioMovimientoProducto
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public DateTime Fecha { get; set; }

    public double CantidadAnterior { get; set; }

    public double CantidadNueva { get; set; }

    public int DepositoId { get; set; }

    public int EmpleadoId { get; set; }

    public virtual InventarioProducto Producto { get; set; } = null!;
}
