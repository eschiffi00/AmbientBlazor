using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoPagoEmpleado
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<LiquidacionHorasPersonalDetalle> LiquidacionHorasPersonalDetalles { get; } = new List<LiquidacionHorasPersonalDetalle>();
}
