using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class OrganizacionPresupuestoDetalle
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public string? MotivoFestejo { get; set; }

    public string? Mail { get; set; }

    public string? Tel { get; set; }

    public string? LocacionOtra { get; set; }

    public string? EnvioMailPresentacion { get; set; }

    public DateTime? FechaMailPresentacion { get; set; }

    public string? RealizoReunionConCliente { get; set; }

    public string? Direccion { get; set; }

    public string? Bocados { get; set; }

    public string? Islas { get; set; }

    public string? Entrada { get; set; }

    public string? PrincipalAdultos { get; set; }

    public string? PrincipalAdolescentes { get; set; }

    public string? PostreAdultosAdolescentes { get; set; }

    public string? PrincipalChicos { get; set; }

    public string? PostreChicos { get; set; }

    public string? MesaDulce { get; set; }

    public string? FinFiesta { get; set; }

    public string? MesaPrincipal { get; set; }

    public string? Manteleria { get; set; }

    public string? Servilletas { get; set; }

    public string? Sillas { get; set; }

    public string? InvitadosDespues00 { get; set; }

    public string? CumpleaniosEnEvento { get; set; }

    public string? TortaAlegorica { get; set; }

    public string? LleganAlSalon { get; set; }

    public string? PlatosEspeciales { get; set; }

    public string? ServiciodeVinoChampagne { get; set; }

    public string? ObservacionBarras { get; set; }

    public string? ObservacionCatering { get; set; }

    public string? ObservacionTecnica { get; set; }

    public string? ObservacionAmbientacion { get; set; }

    public string? ObservacionParticulares { get; set; }

    public string? ObservacionesAdicionales { get; set; }

    public bool BocadosEstado { get; set; }

    public bool IslasEstado { get; set; }

    public bool EntradaEstado { get; set; }

    public bool PrincipalAdultosEstado { get; set; }

    public bool PrincipalAdolescentesEstado { get; set; }

    public bool PostreAdultosAdolescentesEstado { get; set; }

    public bool PrincipalChicosEstado { get; set; }

    public bool PostreChicosEstado { get; set; }

    public bool MesaDulceEstado { get; set; }

    public bool FinFiestaEstado { get; set; }

    public bool MesaPrincipalEstado { get; set; }

    public bool ManteleriaEstado { get; set; }

    public bool ServilletasEstado { get; set; }

    public bool SillasEstado { get; set; }

    public bool InvitadosDespues00Estado { get; set; }

    public bool CumpleaniosEnEventoEstado { get; set; }

    public bool TortaAlegoricaEstado { get; set; }

    public bool LleganAlSalonEstado { get; set; }

    public bool PlatosEspecialesEstado { get; set; }

    public bool ServiciodeVinoChampagneEstado { get; set; }

    public string? Acreditaciones { get; set; }

    public string? ListaInvitados { get; set; }

    public string? ListaCocheras { get; set; }

    public bool AcreditacionesEstado { get; set; }

    public bool ListaInvitadosEstado { get; set; }

    public bool ListaCocherasEstado { get; set; }

    public string? Layout { get; set; }

    public string? AlfombraRoja { get; set; }

    public string? Anexo7 { get; set; }

    public bool LayoutEstado { get; set; }

    public bool AlfombraRojaEstado { get; set; }

    public bool Anexo7Estado { get; set; }

    public string Ramo { get; set; } = null!;

    public string Escenario { get; set; } = null!;

    public string? IngresoProveedoresLugar { get; set; }

    public string? ContactoResponsableLugar { get; set; }

    public string? TelefonoResponsableLugar { get; set; }

    public string? FechaArmadoLogistica { get; set; }

    public string? FechaArmadoSalon { get; set; }

    public string? FechaDesarmadoSalon { get; set; }

    public string? HoraArmadoLogistica { get; set; }

    public string? HoraDesarmadoSalon { get; set; }

    public string? HoraArmadoSalon { get; set; }

    public string? CantPersonasAfectadasArmado { get; set; }

    public bool SePidioHielo { get; set; }

    public bool SePidioLogistica { get; set; }

    public bool SePidioManteleria { get; set; }

    public bool SePidioMoviliario { get; set; }

    public string? ObservacionesHielo { get; set; }

    public string? ObservacionesMoviliario { get; set; }

    public string? ObservacionesLogistica { get; set; }

    public string? ObservacionesManteleria { get; set; }

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
