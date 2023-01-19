using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Movimiento
{
    public int Id { get; set; }

    public int TipoMoviemientoId { get; set; }

    public double Importe { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public virtual TipoMovimiento TipoMoviemiento { get; set; } = null!;
}
