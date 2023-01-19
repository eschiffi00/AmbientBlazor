using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerCliente
{
    public int Id { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? Mail { get; set; }

    public string? Telefono { get; set; }

    public string? Celular { get; set; }

    public DateTime? FechaContacto { get; set; }

    public int? ComollegoId { get; set; }

    public string? ComoLlegoOtro { get; set; }

    public string? Comentario { get; set; }

    public string? RazonSocial { get; set; }

    public string? TipoCliente { get; set; }

    public int? EmpleadoAsignadoId { get; set; }

    public string? Ejecutivo { get; set; }

    public int? EmpleadoId { get; set; }
}
