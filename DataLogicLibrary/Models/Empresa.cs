using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Empresa
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string? Cuit { get; set; }

    public bool? TipoEmpresa { get; set; }

    public string CondicionIva { get; set; } = null!;

    public virtual ICollection<Cuenta> Cuenta { get; } = new List<Cuenta>();

    public virtual ICollection<FacturasCliente> FacturasClientes { get; } = new List<FacturasCliente>();

    public virtual ICollection<PagosCliente> PagosClientes { get; } = new List<PagosCliente>();
}
