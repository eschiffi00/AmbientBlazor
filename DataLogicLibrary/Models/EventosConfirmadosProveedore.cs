using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class EventosConfirmadosProveedore
{
    public int Nropresupuesto { get; set; }

    public int? Diaevento { get; set; }

    public int? Mesevento { get; set; }

    public int? Anioevento { get; set; }

    public long NroComprobante { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string? Cuit { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Cuenta { get; set; } = null!;

    public double? Importepagado { get; set; }

    public double? Costos { get; set; }
}
