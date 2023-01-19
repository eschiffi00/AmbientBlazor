using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class NotaCredito
{
    public int Id { get; set; }

    public int? ComprobanteProveedorId { get; set; }

    public DateTime Fecha { get; set; }

    public double Importe { get; set; }

    public DateTime CreateFecha { get; set; }

    public DateTime? UpdateFecha { get; set; }

    public bool Delete { get; set; }

    public DateTime? DeleteFecha { get; set; }
}
