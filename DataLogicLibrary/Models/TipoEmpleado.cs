using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoEmpleado
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? SectorEmpresaId { get; set; }

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    public virtual SectoresEmpresa? SectorEmpresa { get; set; }
}
