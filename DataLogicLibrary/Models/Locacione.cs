using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Locacione
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string TipoLocacion { get; set; } = null!;

    public int? CapacidadFormal { get; set; }

    public int? CapacidadInformal { get; set; }

    public int? CapacidadAuditorio { get; set; }

    public string? Verde { get; set; }

    public string? AireLibre { get; set; }

    public string? Estacionamiento { get; set; }

    public string? Comentarios { get; set; }

    public double? UsoCocina { get; set; }

    public string TipoCannonCatering { get; set; } = null!;

    public double? Cannon { get; set; }

    public string? TipoCannonBarra { get; set; }

    public double? CannonBarra { get; set; }

    public string? TipoCannonAmbientacion { get; set; }

    public double? CannonAmbientacion { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Mail { get; set; }

    public string? Web { get; set; }

    public int LocalidadId { get; set; }

    public string TieneLogistica { get; set; } = null!;

    public string Comisiona { get; set; } = null!;

    public bool RequiereMesasSillas { get; set; }

    public double? CostoSillas { get; set; }

    public double? CostoMesas { get; set; }

    public double? PrecioSillas { get; set; }

    public double? PrecioMesas { get; set; }

    public virtual ICollection<AmbientacionSalon> AmbientacionSalons { get; } = new List<AmbientacionSalon>();

    public virtual ICollection<Categoria> Categoria { get; } = new List<Categoria>();

    public virtual ICollection<CostoSalone> CostoSalones { get; } = new List<CostoSalone>();

    public virtual ICollection<DegustacionDetalle> DegustacionDetalles { get; } = new List<DegustacionDetalle>();

    public virtual ICollection<Intermediario> Intermediarios { get; } = new List<Intermediario>();

    public virtual ICollection<LocacionesValorAnio> LocacionesValorAnios { get; } = new List<LocacionesValorAnio>();

    public virtual Localidade Localidad { get; set; } = null!;

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();

    public virtual ICollection<Sectore> Sectores { get; } = new List<Sectore>();

    public virtual ICollection<TecnicaSalon> TecnicaSalons { get; } = new List<TecnicaSalon>();
}
