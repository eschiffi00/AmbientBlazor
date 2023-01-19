using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Evento
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public string? ApellidoNombreCliente { get; set; }

    public string? RazonSocial { get; set; }

    public string? Mail { get; set; }

    public string? Tel { get; set; }

    public DateTime Fecha { get; set; }

    public int EstadoId { get; set; }

    public int EmpleadoId { get; set; }

    public string? Comentario { get; set; }

    public double? MontoSena { get; set; }

    public DateTime? FechaSena { get; set; }

    public int? ClienteBisId { get; set; }

    public int? PresupuestoAprobadoId { get; set; }

    public byte[]? ComprobanteAprovacion { get; set; }

    public string? ComprobanteAprovacionExtension { get; set; }

    public int? FormadePagoId { get; set; }

    public string? NroComprobanteTransSenia { get; set; }

    public DateTime? FechaComprobanteTransSenia { get; set; }

    public byte[]? ComprobanteTransferencia { get; set; }

    public string? ComprobanteTransferenciaExtension { get; set; }

    public int? ChequeSenaId { get; set; }

    public double? Indexacion { get; set; }

    public string? TipoIndexacion { get; set; }

    public virtual Cheque? ChequeSena { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual FormasdePago? FormadePago { get; set; }

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();

    public virtual ICollection<ReciboEventoPresupuesto> ReciboEventoPresupuestos { get; } = new List<ReciboEventoPresupuesto>();
}
