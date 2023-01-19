using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoServicioAdicional
{
    public int Id { get; set; }

    public int TipoServicioId { get; set; }

    public int AdicionalId { get; set; }

    public virtual Adicionale Adicional { get; set; } = null!;

    public virtual TipoServicio TipoServicio { get; set; } = null!;
}
