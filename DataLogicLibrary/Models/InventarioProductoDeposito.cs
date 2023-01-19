using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioProductoDeposito
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public int DepositoId { get; set; }

    public double Cantidad { get; set; }

    public int UnidadId { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public virtual InventarioDeposito Deposito { get; set; } = null!;

    public virtual InventarioProducto Producto { get; set; } = null!;
}
