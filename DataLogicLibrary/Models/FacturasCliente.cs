using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class FacturasCliente
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public int TipoComprobanteId { get; set; }

    public int EmpresaId { get; set; }

    public DateTime Fecha { get; set; }

    public double Importe { get; set; }

    public int NroFactura { get; set; }

    public int EstadoId { get; set; }

    public DateTime CreateFecha { get; set; }

    public DateTime? UpdateFecha { get; set; }

    public bool Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public int PresupuestoId { get; set; }

    public virtual ClientesBi Cliente { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<FacturaClienteDetalle> FacturaClienteDetalles { get; } = new List<FacturaClienteDetalle>();

    public virtual TipoComprobante TipoComprobante { get; set; } = null!;
}
