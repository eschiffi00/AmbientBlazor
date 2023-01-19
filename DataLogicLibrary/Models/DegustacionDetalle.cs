using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class DegustacionDetalle
{
    public int Id { get; set; }

    public int DegustacionId { get; set; }

    public int SegmentoId { get; set; }

    public int CaracteristicaId { get; set; }

    public int? TipoEventoId { get; set; }

    public int CantidadInvitados { get; set; }

    public DateTime FechaEvento { get; set; }

    public string? Empresa { get; set; }

    public string? Comensal { get; set; }

    public int? NroMesa { get; set; }

    public int? NroComensal { get; set; }

    public string? EstadoEvento { get; set; }

    public int? LocacionId { get; set; }

    public string? Comentarios { get; set; }

    public string? Telefono { get; set; }

    public string? Mail { get; set; }

    public int EmpleadoId { get; set; }

    public int EstadoId { get; set; }

    public virtual Caracteristica Caracteristica { get; set; } = null!;

    public virtual Degustacion Degustacion { get; set; } = null!;

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual Locacione? Locacion { get; set; }

    public virtual Segmento Segmento { get; set; } = null!;

    public virtual TipoEvento? TipoEvento { get; set; }
}
