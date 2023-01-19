using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Impuesto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public double? Porcentaje { get; set; }

    public virtual ICollection<ComprobantesProveedoresDetalle> ComprobantesProveedoresDetalles { get; } = new List<ComprobantesProveedoresDetalle>();

    public virtual ICollection<TipoComprobanteImpuesto> TipoComprobanteImpuestos { get; } = new List<TipoComprobanteImpuesto>();
}
