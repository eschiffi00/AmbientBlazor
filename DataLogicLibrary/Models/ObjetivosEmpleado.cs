using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObjetivosEmpleado
{
    public int Id { get; set; }

    public int EmpleadoId { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public double Facturacion { get; set; }

    public int CantidadAperturas { get; set; }

    public int Trimestre { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;
}
