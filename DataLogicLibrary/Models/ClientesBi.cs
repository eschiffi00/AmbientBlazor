using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ClientesBi
{
    public int Id { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? RazonSocial { get; set; }

    public string Cuilcuit { get; set; } = null!;

    public string CondicionIva { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string PersonaFisicaJuridica { get; set; } = null!;

    public string TipoCliente { get; set; } = null!;

    public string? MailContactoContratacion { get; set; }

    public string? MailContactoAdministracion { get; set; }

    public string? MailContactoTesoreia { get; set; }

    public string? MailContactoOrganizacion { get; set; }

    public string? TelContactoContratacion { get; set; }

    public string? TelContactoAdministracion { get; set; }

    public string? TelContactoTesoreria { get; set; }

    public string? TelContactoOrganizacion { get; set; }

    public virtual ICollection<FacturasCliente> FacturasClientes { get; } = new List<FacturasCliente>();
}
