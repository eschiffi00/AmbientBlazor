using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Moneda
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<ConversionMoneda> ConversionMonedaMonedaDestinos { get; } = new List<ConversionMoneda>();

    public virtual ICollection<ConversionMoneda> ConversionMonedaMonedaOrigens { get; } = new List<ConversionMoneda>();

    public virtual ICollection<Cuenta> Cuenta { get; } = new List<Cuenta>();
}
