using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Localidade
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<CostoLogistica> CostoLogisticas { get; } = new List<CostoLogistica>();

    public virtual ICollection<Locacione> Locaciones { get; } = new List<Locacione>();
}
