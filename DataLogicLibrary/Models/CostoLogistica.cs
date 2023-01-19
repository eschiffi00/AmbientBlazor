using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoLogistica
{
    public int Id { get; set; }

    public int ConceptoId { get; set; }

    public int Localidad { get; set; }

    public int CantidadInvitados { get; set; }

    public int? TipoEventoId { get; set; }

    public double Costo { get; set; }

    public double Margen { get; set; }

    public double Valor { get; set; }

    public virtual TipoLogistica Concepto { get; set; } = null!;

    public virtual Localidade LocalidadNavigation { get; set; } = null!;
}
