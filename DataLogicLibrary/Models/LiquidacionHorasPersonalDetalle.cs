using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class LiquidacionHorasPersonalDetalle
{
    public int Id { get; set; }

    public int LiquidacionPersonalHoraId { get; set; }

    public int SectorEmpresaId { get; set; }

    public int TipoEmpleadoId { get; set; }

    public int EmpleadoId { get; set; }

    public int TipoPagoId { get; set; }

    public string HoraEntrada { get; set; } = null!;

    public string HoraSalida { get; set; } = null!;

    public double Valor { get; set; }

    public int EstadoId { get; set; }

    public DateTime FechaCreate { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public bool Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual LiquidacionHorasPersonal LiquidacionPersonalHora { get; set; } = null!;

    public virtual TipoPagoEmpleado TipoPago { get; set; } = null!;
}
