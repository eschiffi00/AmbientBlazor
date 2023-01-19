using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class PagosProveedore
{
    public int Id { get; set; }

    public string NroOrdenPago { get; set; } = null!;

    public double Importe { get; set; }

    public DateTime Fecha { get; set; }

    public int CuentaId { get; set; }

    public int FormadePagoId { get; set; }

    public string? NroComprobanteTransferencia { get; set; }

    public DateTime? FechaTransferencia { get; set; }

    public virtual ICollection<ChequesPagosProveedore> ChequesPagosProveedores { get; } = new List<ChequesPagosProveedore>();

    public virtual ICollection<ComprobantePagoProveedor> ComprobantePagoProveedors { get; } = new List<ComprobantePagoProveedor>();

    public virtual Cuenta Cuenta { get; set; } = null!;

    public virtual ICollection<Retencione> Retenciones { get; } = new List<Retencione>();
}
