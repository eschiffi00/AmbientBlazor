using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoServicio
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int RubroId { get; set; }

    public virtual ICollection<ConfiguracionCateringTecnica> ConfiguracionCateringTecnicas { get; } = new List<ConfiguracionCateringTecnica>();

    public virtual ICollection<CostoTecnica> CostoTecnicas { get; } = new List<CostoTecnica>();

    public virtual UnidadesNegocio Rubro { get; set; } = null!;

    public virtual ICollection<TipoServicioAdicional> TipoServicioAdicionals { get; } = new List<TipoServicioAdicional>();
}
