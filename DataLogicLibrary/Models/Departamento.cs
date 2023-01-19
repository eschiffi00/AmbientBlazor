using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<EmpleadoDepartamento1> EmpleadoDepartamento1s { get; } = new List<EmpleadoDepartamento1>();

    public virtual ICollection<SectoresEmpresa> SectoresEmpresas { get; } = new List<SectoresEmpresa>();
}
