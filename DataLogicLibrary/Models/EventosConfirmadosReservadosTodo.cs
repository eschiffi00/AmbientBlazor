using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class EventosConfirmadosReservadosTodo
{
    public int Id { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? RazonSocial { get; set; }

    public string Caracteristica { get; set; } = null!;

    public string Locacion { get; set; } = null!;

    public string? Sector { get; set; }

    public string Jornada { get; set; } = null!;

    public string TipoEvento { get; set; } = null!;

    public int PresupuestoId { get; set; }

    public int EventoId { get; set; }

    public DateTime? FechaEvento { get; set; }

    public int? CantidadInicialInvitados { get; set; }

    public int EstadoId { get; set; }

    public int PresupuestoEstadoId { get; set; }

    public string? Ejecutivo { get; set; }

    public int? Coordinador1 { get; set; }

    public int? Coordinador2 { get; set; }

    public int TipoEventoId { get; set; }
}
