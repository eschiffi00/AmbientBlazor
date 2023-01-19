using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Perfile
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();

    public virtual ICollection<Usuario1> Usuario1s { get; } = new List<Usuario1>();
}
