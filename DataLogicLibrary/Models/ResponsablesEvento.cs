using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ResponsablesEvento
{
    public int PresupuestoId { get; set; }

    public DateTime? FechaEvento { get; set; }

    public string? HorarioEvento { get; set; }

    public string? HoraFinalizado { get; set; }

    public string? Caracteristica { get; set; }

    public string? Segmento { get; set; }

    public string? RazonSocial { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? Locacion { get; set; }

    public int? TotalInvitados { get; set; }

    public string? RespCocina { get; set; }

    public string? RespBarra { get; set; }

    public string? RespLogistica { get; set; }

    public string? RespOperaciones { get; set; }

    public string? RespSalon { get; set; }

    public string? Coordinador1 { get; set; }

    public string? Coordinador2 { get; set; }

    public string? Organizador { get; set; }

    public string? RespLogisticaArmado { get; set; }

    public string? RespLogisticaDesarmado { get; set; }

    public int? OrganizadorId { get; set; }

    public int? Coordinador1Id { get; set; }

    public int? Coordinador2Id { get; set; }

    public string? HoraIngresoCoordinador1 { get; set; }

    public string? HoraIngresoCoordinador2 { get; set; }
}
