using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ChequesPagosProveedore
{
    public int Id { get; set; }

    public int PagoProveedorId { get; set; }

    public int ChequeId { get; set; }

    public virtual Cheque Cheque { get; set; } = null!;

    public virtual PagosProveedore PagoProveedor { get; set; } = null!;
}
