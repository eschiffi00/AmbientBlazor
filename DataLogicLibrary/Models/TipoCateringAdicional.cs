using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoCateringAdicional
{
    public int Id { get; set; }

    public int TipoCateringId { get; set; }

    public int AdicionalId { get; set; }

    public virtual Adicionale Adicional { get; set; } = null!;

    public virtual TipoCatering TipoCatering { get; set; } = null!;
}
