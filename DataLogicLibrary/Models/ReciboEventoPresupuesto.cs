using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ReciboEventoPresupuesto
{
    public int Id { get; set; }

    public int ReciboId { get; set; }

    public int EventoId { get; set; }

    public int? PresupuestoId { get; set; }

    public virtual Evento Evento { get; set; } = null!;

    public virtual Presupuesto? Presupuesto { get; set; }

    public virtual Recibo Recibo { get; set; } = null!;
}
