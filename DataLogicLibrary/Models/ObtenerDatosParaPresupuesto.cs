using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerDatosParaPresupuesto
{
    public int ClienteId { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? Mail { get; set; }

    public string? Celular { get; set; }

    public int SegmentoId { get; set; }

    public string Segmento { get; set; } = null!;

    public int CaracteristicaId { get; set; }

    public string Caracteristica { get; set; } = null!;

    public int? SectorId { get; set; }

    public string? Sector { get; set; }

    public int TipoEventoId { get; set; }

    public string TipoEvento { get; set; } = null!;

    public int LocacionId { get; set; }

    public string Locacion { get; set; } = null!;

    public string TipoLocacion { get; set; } = null!;

    public int JornadaId { get; set; }

    public string Jornada { get; set; } = null!;

    public int? CantidadInicialInvitados { get; set; }

    public int? CantidadInvitadosMenores3 { get; set; }

    public int? CantidadInvitadosMenores3y8 { get; set; }

    public int? CantidadInvitadosAdolecentes { get; set; }

    public DateTime? FechaEvento { get; set; }

    public string? HorarioEvento { get; set; }

    public string? HorarioArmado { get; set; }

    public string? HoraFinalizado { get; set; }

    public string? Comentario { get; set; }

    public int EventoId { get; set; }

    public int EmpleadoId { get; set; }

    public string? Ejecutivo { get; set; }

    public DateTime FechaContacto { get; set; }

    public int? PresupuestoId { get; set; }

    public string? RazonSocial { get; set; }

    public double? PrecioTotal { get; set; }

    public double? PrecioPorPersona { get; set; }

    public string? ComentarioPresupuesto { get; set; }

    public DateTime? FechaPresupuesto { get; set; }

    public string? LocacionOtra { get; set; }
}
