using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Estado
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Entidad { get; set; }

    public virtual ICollection<Adicionale> Adicionales { get; } = new List<Adicionale>();

    public virtual ICollection<Cheque> Cheques { get; } = new List<Cheque>();

    public virtual ICollection<ComprobantesProveedore> ComprobantesProveedores { get; } = new List<ComprobantesProveedore>();

    public virtual ICollection<DegustacionDetalle> DegustacionDetalles { get; } = new List<DegustacionDetalle>();

    public virtual ICollection<Degustacion> Degustacions { get; } = new List<Degustacion>();

    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    public virtual ICollection<Evento> Eventos { get; } = new List<Evento>();

    public virtual ICollection<FacturasCliente> FacturasClientes { get; } = new List<FacturasCliente>();

    public virtual ICollection<PagosCliente> PagosClientes { get; } = new List<PagosCliente>();

    public virtual ICollection<Presupuesto> Presupuestos { get; } = new List<Presupuesto>();

    public virtual ICollection<Usuario1> Usuario1s { get; } = new List<Usuario1>();
}
