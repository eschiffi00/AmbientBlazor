using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class OrganizacionPresupuestosArchivo
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public string? Desripcion { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Extension { get; set; }

    public byte[]? Archivo { get; set; }

    public DateTime CreateFecha { get; set; }

    public int EmpleadoId { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
