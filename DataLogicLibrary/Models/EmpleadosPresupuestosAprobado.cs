using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class EmpleadosPresupuestosAprobado
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int? CoordinadorId { get; set; }

    public int? CoordinadorBisId { get; set; }

    public string? HoraIngresoCoordinador1 { get; set; }

    public string? HoraIngresoCoordinador2 { get; set; }

    public int? JefeSalonId { get; set; }

    public int? JefeCocinaId { get; set; }

    public int? JefeBarraId { get; set; }

    public int? JefeOperacionId { get; set; }

    public int? JefeLogisticaId { get; set; }

    public int? OrganizadorId { get; set; }

    public int? ResponsableLogisticaArmadoId { get; set; }

    public int? ResponsableLogisticaDesarmadoId { get; set; }

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
