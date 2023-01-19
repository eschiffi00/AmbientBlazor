using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CondicionIva
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; } = new List<Proveedore>();

    public virtual ICollection<TipoComprobante> TipoComprobantes { get; } = new List<TipoComprobante>();
}
