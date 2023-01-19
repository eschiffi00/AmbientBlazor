using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class FormasdePago
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<ComprobantesProveedore> ComprobantesProveedores { get; } = new List<ComprobantesProveedore>();

    public virtual ICollection<Evento> Eventos { get; } = new List<Evento>();

    public virtual ICollection<PagosCliente> PagosClientes { get; } = new List<PagosCliente>();

    public virtual ICollection<ProveedoresFormasdePago> ProveedoresFormasdePagos { get; } = new List<ProveedoresFormasdePago>();

    public virtual ICollection<Recibo> Recibos { get; } = new List<Recibo>();
}
