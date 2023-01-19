using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Provincia
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Ciudade> Ciudades { get; } = new List<Ciudade>();
}
