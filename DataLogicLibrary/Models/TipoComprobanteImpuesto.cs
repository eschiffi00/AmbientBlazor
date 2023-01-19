using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoComprobanteImpuesto
{
    public int Id { get; set; }

    public int TipoComprobanteId { get; set; }

    public int ImpuestoId { get; set; }

    public virtual Impuesto Impuesto { get; set; } = null!;

    public virtual TipoComprobante TipoComprobante { get; set; } = null!;
}
