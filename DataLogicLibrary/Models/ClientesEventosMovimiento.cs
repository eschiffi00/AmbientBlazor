using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ClientesEventosMovimiento
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public int EventoId { get; set; }

    public string? Comentario { get; set; }

    public DateTime FechaSeguimiento { get; set; }

    public int? EstadoId { get; set; }

    public int? EmpleadoId { get; set; }
}
