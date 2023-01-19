using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class EmpleadoDepartamento1
{
    public int Id { get; set; }

    public int EmpleadoId { get; set; }

    public int DepartamentoId { get; set; }

    public virtual Departamento Departamento { get; set; } = null!;

    public virtual Empleado Empleado { get; set; } = null!;
}
