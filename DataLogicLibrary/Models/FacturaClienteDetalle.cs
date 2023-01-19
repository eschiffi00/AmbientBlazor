using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class FacturaClienteDetalle
{
    public int Id { get; set; }

    public int FacturaClienteId { get; set; }

    public string Descripcion { get; set; } = null!;

    public double Cantidad { get; set; }

    public double Importe { get; set; }

    public bool Grabado { get; set; }

    public DateTime CreateFecha { get; set; }

    public DateTime? UpdateFecha { get; set; }

    public bool Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public virtual FacturasCliente FacturaCliente { get; set; } = null!;
}
