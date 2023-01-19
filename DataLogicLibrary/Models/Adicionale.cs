using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Adicionale
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? RubroId { get; set; }

    public double? Precio { get; set; }

    public int EstadoId { get; set; }

    public string RequiereCantidad { get; set; } = null!;

    public string RequiereCantidadRango { get; set; } = null!;

    public int? ProveedorId { get; set; }

    public double? Costo { get; set; }

    public int? LocacionId { get; set; }

    public string SoloMayores { get; set; } = null!;

    public virtual ICollection<AdicionalesItem> AdicionalesItems { get; } = new List<AdicionalesItem>();

    public virtual ICollection<CostoAdicionale> CostoAdicionales { get; } = new List<CostoAdicionale>();

    public virtual Estado Estado { get; set; } = null!;

    public virtual UnidadesNegocio? Rubro { get; set; }

    public virtual ICollection<TipoCateringAdicional> TipoCateringAdicionals { get; } = new List<TipoCateringAdicional>();

    public virtual ICollection<TipoServicioAdicional> TipoServicioAdicionals { get; } = new List<TipoServicioAdicional>();
}
