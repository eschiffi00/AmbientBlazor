using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Degustacion
{
    public int Id { get; set; }

    public DateTime FechaDegustacion { get; set; }

    public int? CantidadMesas { get; set; }

    public int Locacion { get; set; }

    public string HoraCorporativo { get; set; } = null!;

    public string HoraSocial { get; set; } = null!;

    public int EstadoId { get; set; }

    public bool ConfirmoTecnica { get; set; }

    public bool ConfirmoAmbientacion { get; set; }

    public virtual ICollection<DegustacionDetalle> DegustacionDetalles { get; } = new List<DegustacionDetalle>();

    public virtual Estado Estado { get; set; } = null!;
}
