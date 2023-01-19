using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class AvisosClientesPorFecha
{
    public int Id { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? RazonSocial { get; set; }

    public string Comentario { get; set; } = null!;

    public DateTime? FechaAviso { get; set; }

    public int EmpleadoId { get; set; }

    public int ClienteId { get; set; }
}
