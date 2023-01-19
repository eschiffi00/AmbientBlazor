using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoCanon
{
    public int Id { get; set; }

    public int SegmentoId { get; set; }

    public int CaracteristicaId { get; set; }

    public int TipoCateringId { get; set; }

    public double? CanonInterno { get; set; }

    public double? CanonExterno { get; set; }

    public double? UsoCocina { get; set; }

    public virtual Caracteristica Caracteristica { get; set; } = null!;

    public virtual Segmento Segmento { get; set; } = null!;

    public virtual TipoCatering TipoCatering { get; set; } = null!;
}
