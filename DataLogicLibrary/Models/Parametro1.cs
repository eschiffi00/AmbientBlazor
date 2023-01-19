using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Parametro1
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Valor { get; set; } = null!;
}
