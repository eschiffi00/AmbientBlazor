using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoEvento
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<DegustacionDetalle> DegustacionDetalles { get; } = new List<DegustacionDetalle>();

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();
}
