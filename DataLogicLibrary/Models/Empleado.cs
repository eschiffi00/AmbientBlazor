using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? Nombre { get; set; }

    public int NroLegajo { get; set; }

    public string? Mail { get; set; }

    public string? MailLaboral { get; set; }

    public string? TipoDocumento { get; set; }

    public int? NroDocumento { get; set; }

    public string? Cuil { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Direccion { get; set; }

    public string? DireccionLegal { get; set; }

    public int LocalidadId { get; set; }

    public int? CiudadLegalId { get; set; }

    public string? Cp { get; set; }

    public string? Cplegal { get; set; }

    public string? TelefonoFijo { get; set; }

    public string? TelefonoMovil { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? TelefonoFijoLaboral { get; set; }

    public string? CelularFijoLaboral { get; set; }

    public bool UsaPc { get; set; }

    public string? NroPc { get; set; }

    public int? EstadoId { get; set; }

    public int SectorEmpresaId { get; set; }

    public int TipoEmpleadoId { get; set; }

    public string? HorarioDesde { get; set; }

    public string? HorarioHasta { get; set; }

    public double? Sueldo { get; set; }

    public double? Premio { get; set; }

    public double? Sac { get; set; }

    public string? Observaciones { get; set; }

    public int DepartamentoId { get; set; }

    public virtual Ciudade? CiudadLegal { get; set; }

    public virtual ICollection<DegustacionDetalle> DegustacionDetalles { get; } = new List<DegustacionDetalle>();

    public virtual ICollection<EmpleadoDepartamento1> EmpleadoDepartamento1s { get; } = new List<EmpleadoDepartamento1>();

    public virtual Estado? Estado { get; set; }

    public virtual ICollection<Evento> Eventos { get; } = new List<Evento>();

    public virtual ICollection<LiquidacionHorasPersonalDetalle> LiquidacionHorasPersonalDetalles { get; } = new List<LiquidacionHorasPersonalDetalle>();

    public virtual Ciudade Localidad { get; set; } = null!;

    public virtual ICollection<ObjetivosEmpleado> ObjetivosEmpleados { get; } = new List<ObjetivosEmpleado>();

    public virtual ICollection<OrganizacionPresupuestosArchivo> OrganizacionPresupuestosArchivos { get; } = new List<OrganizacionPresupuestosArchivo>();

    public virtual SectoresEmpresa SectorEmpresa { get; set; } = null!;

    public virtual TipoEmpleado TipoEmpleado { get; set; } = null!;

    public virtual Usuario1? Usuario1 { get; set; }
}
