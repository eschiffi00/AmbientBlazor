using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class FechasBloqueada
{
    public int Id { get; set; }

    public DateTime FechaBloqueada { get; set; }

    public int LocacionId { get; set; }
}
