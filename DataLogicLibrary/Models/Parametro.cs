using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Parametro
{
    public int ParametroId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
