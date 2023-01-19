using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Empleadodepartamento
{
    public int EmpleadoId { get; set; }

    public int DepartamentoId { get; set; }

    public string? ApellidoNombre { get; set; }
}
