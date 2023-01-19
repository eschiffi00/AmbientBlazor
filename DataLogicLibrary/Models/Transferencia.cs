using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Transferencia
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public int? ProveedorId { get; set; }

    public int BancoId { get; set; }

    public string NroTransferencia { get; set; } = null!;

    public double Importe { get; set; }

    public string? NombreArchivo { get; set; }

    public byte[]? Comprobante { get; set; }

    public string? ComprobanteExtension { get; set; }

    public DateTime FechaTransferencia { get; set; }

    public DateTime FechaCreate { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public bool Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public virtual Banco Banco { get; set; } = null!;
}
