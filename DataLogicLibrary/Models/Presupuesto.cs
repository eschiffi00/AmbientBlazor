using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Presupuesto
{
    public int Id { get; set; }

    public int EventoId { get; set; }

    public DateTime FechaPresupuesto { get; set; }

    public double? PrecioTotal { get; set; }

    public double? PrecioPorPersona { get; set; }

    public string? Comentario { get; set; }

    public int SegmentoId { get; set; }

    public int CaracteristicaId { get; set; }

    public int? SectorId { get; set; }

    public int TipoEventoId { get; set; }

    public string? TipoEventoOtro { get; set; }

    public int LocacionId { get; set; }

    public string? LocacionOtra { get; set; }

    public string? DireccionOtra { get; set; }

    public int? DuracionId { get; set; }

    public int? JornadaId { get; set; }

    public int? MomentoDiaId { get; set; }

    public string? HorarioEvento { get; set; }

    public string? HoraFinalizado { get; set; }

    public string? HorarioArmado { get; set; }

    public int? CantidadInicialInvitados { get; set; }

    public DateTime? FechaEvento { get; set; }

    public int EstadoId { get; set; }

    public int? CantidadInvitadosMenores3 { get; set; }

    public int? CantidadInvitadosMenores3y8 { get; set; }

    public int? CantidadInvitadosAdolecentes { get; set; }

    public int? PresupuestoIdAnterior { get; set; }

    public double? ImporteOrganizador { get; set; }

    public double? PorcentajeOrganizador { get; set; }

    public double? ValorOrganizador { get; set; }

    public DateTime? FechaCaducidad { get; set; }

    public int? CantidadAdultosFinal { get; set; }

    public int? CantidadAdolescentesFinal { get; set; }

    public int? CantidadMenores3Final { get; set; }

    public int? CantidadMenoresEntre3y8Final { get; set; }

    public double? ValorRoyaltyOrganizador { get; set; }

    public virtual Caracteristica Caracteristica { get; set; } = null!;

    public virtual ICollection<ComprobantesProveedoresDetalle> ComprobantesProveedoresDetalles { get; } = new List<ComprobantesProveedoresDetalle>();

    public virtual DuracionEvento? Duracion { get; set; }

    public virtual ICollection<EmpleadosPresupuestosAprobado> EmpleadosPresupuestosAprobados { get; } = new List<EmpleadosPresupuestosAprobado>();

    public virtual Estado Estado { get; set; } = null!;

    public virtual Evento Evento { get; set; } = null!;

    public virtual Jornada? Jornada { get; set; }

    public virtual Locacione Locacion { get; set; } = null!;

    public virtual MomentosDia? MomentoDia { get; set; }

    public virtual OrganizacionPresupuestoDetalle? OrganizacionPresupuestoDetalle { get; set; }

    public virtual ICollection<OrganizacionPresupuestoProveedoresExterno> OrganizacionPresupuestoProveedoresExternos { get; } = new List<OrganizacionPresupuestoProveedoresExterno>();

    public virtual ICollection<OrganizacionPresupuestoTimming> OrganizacionPresupuestoTimmings { get; } = new List<OrganizacionPresupuestoTimming>();

    public virtual ICollection<OrganizacionPresupuestosArchivo> OrganizacionPresupuestosArchivos { get; } = new List<OrganizacionPresupuestosArchivo>();

    public virtual ICollection<PagosCliente> PagosClientes { get; } = new List<PagosCliente>();

    public virtual ICollection<PresupuestoDetalle> PresupuestoDetalles { get; } = new List<PresupuestoDetalle>();

    public virtual ICollection<ReciboEventoPresupuesto> ReciboEventoPresupuestos { get; } = new List<ReciboEventoPresupuesto>();

    public virtual Segmento Segmento { get; set; } = null!;

    public virtual TipoEvento TipoEvento { get; set; } = null!;
}
