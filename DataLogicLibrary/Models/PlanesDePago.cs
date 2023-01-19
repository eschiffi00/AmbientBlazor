using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class PlanesDePago
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public double Indice { get; set; }
}
