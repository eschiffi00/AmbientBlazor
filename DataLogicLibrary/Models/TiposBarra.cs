using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TiposBarra
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int SegmentoId { get; set; }

    public int DuracionId { get; set; }

    public string RangoEtareo { get; set; } = null!;

    public virtual ICollection<CostoBarra> CostoBarras { get; } = new List<CostoBarra>();

    public virtual DuracionEvento Duracion { get; set; } = null!;

    public virtual Segmento Segmento { get; set; } = null!;

    public virtual ICollection<TipoBarraCategoriaItem> TipoBarraCategoriaItems { get; } = new List<TipoBarraCategoriaItem>();
}
