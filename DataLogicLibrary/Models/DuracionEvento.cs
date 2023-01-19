using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class DuracionEvento
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? CantidadHoras { get; set; }

    public virtual ICollection<ConfiguracionCateringTecnica> ConfiguracionCateringTecnicas { get; } = new List<ConfiguracionCateringTecnica>();

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();

    public virtual ICollection<TiposBarra> TiposBarras { get; } = new List<TiposBarra>();
}
