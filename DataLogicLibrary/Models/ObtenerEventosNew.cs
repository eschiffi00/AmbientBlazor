using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerEventosNew
{
    public string? ApellidoNombre { get; set; }

    public string Caracteristica { get; set; } = null!;

    public string Locacion { get; set; } = null!;

    public string? Sector { get; set; }

    public string Jornada { get; set; } = null!;

    public string? HorarioEvento { get; set; }

    public int? CantidadInicialInvitados { get; set; }

    public DateTime? FechaEvento { get; set; }

    public int Id { get; set; }

    public string Estado { get; set; } = null!;

    public string? Ejecutivo { get; set; }

    public int EventoId { get; set; }

    public int ClienteId { get; set; }

    public int EmpleadoId { get; set; }

    public int EstadoId { get; set; }

    public string RazonSocial { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int PresupuestoId { get; set; }

    public int PresupuestoEstadoId { get; set; }

    public string EstadoPresupuesto { get; set; } = null!;

    public int? PresupuestoIdAnterior { get; set; }

    public int LocacionId { get; set; }

    public int EmpleadoCliente { get; set; }

    public string TipoEvento { get; set; } = null!;

    public int? ClienteBisId { get; set; }

    public string? Cliente { get; set; }

    public DateTime? FechaSena { get; set; }

    public int TipoEventoId { get; set; }

    public string? TipoExperiencia { get; set; }

    public string? TipoBarra { get; set; }
}
