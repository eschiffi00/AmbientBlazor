using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Eventostodo
{
    public int Id { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? RazonSocial { get; set; }

    public string? Locacion { get; set; }

    public int? CantidadInicialInvitados { get; set; }

    public string? Ejecutivo { get; set; }

    public string? TipoEventos { get; set; }

    public string? Estado { get; set; }

    public int Nropresupuesto { get; set; }
}
