using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoComprobante
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? CondicionIvaId { get; set; }

    public virtual ICollection<ComprobantesProveedore> ComprobantesProveedores { get; } = new List<ComprobantesProveedore>();

    public virtual CondicionIva? CondicionIva { get; set; }

    public virtual ICollection<FacturasCliente> FacturasClientes { get; } = new List<FacturasCliente>();

    public virtual ICollection<TipoComprobanteImpuesto> TipoComprobanteImpuestos { get; } = new List<TipoComprobanteImpuesto>();
}
