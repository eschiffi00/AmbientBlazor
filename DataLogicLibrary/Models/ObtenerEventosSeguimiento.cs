using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerEventosSeguimiento
{
    public int EventoId { get; set; }

    public int ClienteId { get; set; }

    public string? RazonSocial { get; set; }

    public string? ApellidoNombreCliente { get; set; }

    public string? Mail { get; set; }

    public string? Celular { get; set; }

    public string? ApellidoNombre { get; set; }

    public string Descripcion { get; set; } = null!;

    public int EstadoId { get; set; }

    public DateTime Fecha { get; set; }

    public int EmpleadoId { get; set; }

    public string? Comentario { get; set; }
}
