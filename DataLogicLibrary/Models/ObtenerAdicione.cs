using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerAdicione
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public double? Precio { get; set; }

    public int RubroId { get; set; }

    public string Rubro { get; set; } = null!;

    public int EstadoId { get; set; }

    public string EstadoDescripcion { get; set; } = null!;

    public string? RequiereCantidad { get; set; }

    public int? ProveedorId { get; set; }

    public double? Costo { get; set; }
}
