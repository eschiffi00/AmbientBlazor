using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoCatering
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? EsAdicional { get; set; }

    public int RubroId { get; set; }

    public int EstadoId { get; set; }

    public virtual ICollection<ConfiguracionCateringTecnica> ConfiguracionCateringTecnicas { get; } = new List<ConfiguracionCateringTecnica>();

    public virtual ICollection<CostoCanon> CostoCanons { get; } = new List<CostoCanon>();

    public virtual ICollection<CostoCatering> CostoCaterings { get; } = new List<CostoCatering>();

    public virtual UnidadesNegocio Rubro { get; set; } = null!;

    public virtual ICollection<TipoCateringAdicional> TipoCateringAdicionals { get; } = new List<TipoCateringAdicional>();

    public virtual ICollection<TipoCateringTiempoProductoItem> TipoCateringTiempoProductoItems { get; } = new List<TipoCateringTiempoProductoItem>();
}
