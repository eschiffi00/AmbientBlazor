using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class UnidadesNegociosTipoMovimiento
{
    public int Id { get; set; }

    public int UnidadNegocioId { get; set; }

    public int TipoMovimientoId { get; set; }

    public virtual TipoMovimiento TipoMovimiento { get; set; } = null!;

    public virtual UnidadesNegocio UnidadNegocio { get; set; } = null!;
}
