using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class GruposItem
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Familia> Familia { get; } = new List<Familia>();
}
