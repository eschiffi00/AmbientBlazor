using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Categoria
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int LocacionId { get; set; }

    public int SectorId { get; set; }

    public int CaracteristicaId { get; set; }

    public int SegmentoId { get; set; }

    public int EstadoId { get; set; }

    public virtual Caracteristica Caracteristica { get; set; } = null!;

    public virtual ICollection<CostoAmbientacion> CostoAmbientacions { get; } = new List<CostoAmbientacion>();

    public virtual Locacione Locacion { get; set; } = null!;

    public virtual Segmento Segmento { get; set; } = null!;
}
