using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Recibo
{
    public int Id { get; set; }

    public string NroRecibo { get; set; } = null!;

    public DateTime FechaRecibo { get; set; }

    public string Concepto { get; set; } = null!;

    public DateTime FechaCreate { get; set; }

    public double Importe { get; set; }

    public int FormadePagoId { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public bool Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public virtual FormasdePago FormadePago { get; set; } = null!;

    public virtual ICollection<ReciboEventoPresupuesto> ReciboEventoPresupuestos { get; } = new List<ReciboEventoPresupuesto>();
}
