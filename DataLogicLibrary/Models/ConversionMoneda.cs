using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ConversionMoneda
{
    public int Id { get; set; }

    public int MonedaOrigenId { get; set; }

    public int MonedaDestinoId { get; set; }

    public string Conversion { get; set; } = null!;

    public virtual Moneda MonedaDestino { get; set; } = null!;

    public virtual Moneda MonedaOrigen { get; set; } = null!;
}
