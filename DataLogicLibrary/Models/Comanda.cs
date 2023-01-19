using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Comanda
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public DateTime? FechaEvento { get; set; }

    public string? Locacion { get; set; }

    public string? HorarioLlegada { get; set; }

    public string? HorarioInicio { get; set; }

    public string? HorarioFin { get; set; }

    public string? TipoEvento { get; set; }

    public string? TipoExperiencia { get; set; }

    public int? Duracion { get; set; }

    public string? Empresa { get; set; }

    public string? Organizador { get; set; }

    public string? Maitre { get; set; }

    public string? Coordinador { get; set; }

    public string? JefeProducto { get; set; }

    public int? Adultos { get; set; }

    public int? Menores3 { get; set; }

    public int? Menores3y8 { get; set; }

    public int? Adolescentes { get; set; }

    public int EstadoId { get; set; }
}
