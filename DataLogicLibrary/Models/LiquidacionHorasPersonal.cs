using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class LiquidacionHorasPersonal
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int EstadoId { get; set; }

    public int PresupuestoId { get; set; }

    public DateTime FechaCreate { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public bool Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public virtual ICollection<LiquidacionHorasPersonalDetalle> LiquidacionHorasPersonalDetalles { get; } = new List<LiquidacionHorasPersonalDetalle>();
}
