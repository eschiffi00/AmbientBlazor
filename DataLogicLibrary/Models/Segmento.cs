using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Segmento
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Categoria> Categoria { get; } = new List<Categoria>();

    public virtual ICollection<ConfiguracionCateringTecnica> ConfiguracionCateringTecnicas { get; } = new List<ConfiguracionCateringTecnica>();

    public virtual ICollection<CostoCanon> CostoCanons { get; } = new List<CostoCanon>();

    public virtual ICollection<CostoTecnica> CostoTecnicas { get; } = new List<CostoTecnica>();

    public virtual ICollection<CostosPaquetesCiambientacion> CostosPaquetesCiambientacions { get; } = new List<CostosPaquetesCiambientacion>();

    public virtual ICollection<DegustacionDetalle> DegustacionDetalles { get; } = new List<DegustacionDetalle>();

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();

    public virtual ICollection<TiposBarra> TiposBarras { get; } = new List<TiposBarra>();
}
