using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ProveedoresExterno
{
    public int Id { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public string? HorarioEvento { get; set; }

    public string? HoraFinalizado { get; set; }

    public string? Ejecutivo { get; set; }

    public int? TotalInvitados { get; set; }

    public string? Locacion { get; set; }

    public string? Proveedor { get; set; }

    public string? Rubro { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public DateTime? FechaEvento { get; set; }
}
