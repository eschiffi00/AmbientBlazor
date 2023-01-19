using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ConfiguracionCateringTecnica
{
    public int Id { get; set; }

    public int SegmentoId { get; set; }

    public int CaracteristicaId { get; set; }

    public int DuracionId { get; set; }

    public int MomentoDiaId { get; set; }

    public int TipoCateringId { get; set; }

    public int? TipoServicioId { get; set; }

    public int EstadoId { get; set; }

    public virtual Caracteristica Caracteristica { get; set; } = null!;

    public virtual DuracionEvento Duracion { get; set; } = null!;

    public virtual MomentosDia MomentoDia { get; set; } = null!;

    public virtual Segmento Segmento { get; set; } = null!;

    public virtual TipoCatering TipoCatering { get; set; } = null!;

    public virtual TipoServicio? TipoServicio { get; set; }
}
