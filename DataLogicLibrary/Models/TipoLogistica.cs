using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoLogistica
{
    public int Id { get; set; }

    public string Concepto { get; set; } = null!;

    public virtual ICollection<CostoLogistica> CostoLogisticas { get; } = new List<CostoLogistica>();
}
