using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class OrganizacionPresupuestoTimming
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public string HoraInicio { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Duracion { get; set; } = null!;

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
