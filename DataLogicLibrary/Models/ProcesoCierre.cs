using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ProcesoCierre
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public int Orden { get; set; }
}
