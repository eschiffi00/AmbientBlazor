using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class OrganizacionPresupuestoProveedoresExterno
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public string? ProveedorExterno { get; set; }

    public string? Rubro { get; set; }

    public string? Contacto { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Observaciones { get; set; }

    public bool SegurosOk { get; set; }

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
