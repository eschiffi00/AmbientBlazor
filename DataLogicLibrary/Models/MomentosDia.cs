using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class MomentosDia
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ConfiguracionCateringTecnica> ConfiguracionCateringTecnicas { get; } = new List<ConfiguracionCateringTecnica>();

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();
}
