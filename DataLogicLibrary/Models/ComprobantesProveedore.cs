using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ComprobantesProveedore
{
    public int Id { get; set; }

    public int? ProveedorId { get; set; }

    public int? CuentaId { get; set; }

    public int TipoComprobanteId { get; set; }

    public int FormadePagoId { get; set; }

    public int? EmpresaId { get; set; }

    public double MontoNeto { get; set; }

    public double? MontoFactura { get; set; }

    public long PuntoVenta { get; set; }

    public long NroComprobante { get; set; }

    public DateTime Fecha { get; set; }

    public double? Iva21 { get; set; }

    public double? Iva27 { get; set; }

    public double? Iva105 { get; set; }

    public double? Iibbcaba { get; set; }

    public double? Iibbarba { get; set; }

    public double? PercepcionIva { get; set; }

    public string? GeneraOp { get; set; }

    public int EstadoId { get; set; }

    public DateTime CreateFecha { get; set; }

    public DateTime? UpdateFecha { get; set; }

    public bool Delete { get; set; }

    public DateTime? DeleteFecha { get; set; }

    public virtual ICollection<ComprobantePagoProveedor> ComprobantePagoProveedors { get; } = new List<ComprobantePagoProveedor>();

    public virtual ICollection<ComprobantesProveedoresDetalle> ComprobantesProveedoresDetalles { get; } = new List<ComprobantesProveedoresDetalle>();

    public virtual Cuenta? Cuenta { get; set; }

    public virtual Estado Estado { get; set; } = null!;

    public virtual FormasdePago FormadePago { get; set; } = null!;

    public virtual Proveedore? Proveedor { get; set; }

    public virtual TipoComprobante TipoComprobante { get; set; } = null!;
}
