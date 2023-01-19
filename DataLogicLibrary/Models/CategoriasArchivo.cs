using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CategoriasArchivo
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Herramienta> Herramienta { get; } = new List<Herramienta>();
}
