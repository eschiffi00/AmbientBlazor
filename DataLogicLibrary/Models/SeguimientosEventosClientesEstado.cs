using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class SeguimientosEventosClientesEstado
{
    public int ClienteId { get; set; }

    public int EventoId { get; set; }

    public int Id { get; set; }

    public string? RazonSocial { get; set; }

    public string? ApellidoNombreCliente { get; set; }

    public string? Mail { get; set; }

    public string? Celular { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? Comentario { get; set; }

    public DateTime FechaSeguimiento { get; set; }

    public string Descripcion { get; set; } = null!;

    public int EstadoId { get; set; }

    public string Caracteristica { get; set; } = null!;

    public string TipoEvento { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int? CantidadInicialInvitados { get; set; }

    public int EmpleadoId { get; set; }

    public int PresupuestoId { get; set; }

    public int PresupuestoEstadoId { get; set; }

    public string EstadoPresupuesto { get; set; } = null!;

    public DateTime? FechaEvento { get; set; }

    public int? PresupuestoIdAnterior { get; set; }
}
