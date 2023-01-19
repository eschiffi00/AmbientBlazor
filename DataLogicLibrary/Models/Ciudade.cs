using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Ciudade
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Cp { get; set; }

    public int ProvinciaId { get; set; }

    public virtual ICollection<Empleado> EmpleadoCiudadLegals { get; } = new List<Empleado>();

    public virtual ICollection<Empleado> EmpleadoLocalidads { get; } = new List<Empleado>();

    public virtual Provincia Provincia { get; set; } = null!;
}
