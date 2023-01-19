using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class SectoresEmpresa
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int DepartamentoId { get; set; }

    public virtual Departamento Departamento { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    public virtual ICollection<TipoEmpleado> TipoEmpleados { get; } = new List<TipoEmpleado>();
}
