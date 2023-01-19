using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Cheque
{
    public int Id { get; set; }

    public string NroCheque { get; set; } = null!;

    public double Importe { get; set; }

    public string? EmitidoA { get; set; }

    public DateTime FechaEmision { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public int? ClienteId { get; set; }

    public int? ProveedorId { get; set; }

    public int BancoId { get; set; }

    public string? Observaciones { get; set; }

    public string? TipoCheque { get; set; }

    public int EstadoId { get; set; }

    public int? CuentaId { get; set; }

    public virtual Banco Banco { get; set; } = null!;

    public virtual ICollection<ChequesPagosProveedore> ChequesPagosProveedores { get; } = new List<ChequesPagosProveedore>();

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<Evento> Eventos { get; } = new List<Evento>();
}
