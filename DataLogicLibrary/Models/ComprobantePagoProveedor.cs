using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ComprobantePagoProveedor
{
    public int Id { get; set; }

    public int ComprobanteProveedorId { get; set; }

    public int PagoProveedorId { get; set; }

    public virtual ComprobantesProveedore ComprobanteProveedor { get; set; } = null!;

    public virtual PagosProveedore PagoProveedor { get; set; } = null!;
}
