using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoMovimiento
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Tipo { get; set; }

    public string? Visible { get; set; }

    public bool? IsEgreso { get; set; }

    public bool? IsIngreso { get; set; }

    public string? TipoGasto { get; set; }

    public virtual ICollection<ComprobantesProveedoresDetalle> ComprobantesProveedoresDetalles { get; } = new List<ComprobantesProveedoresDetalle>();

    public virtual ICollection<Movimiento> Movimientos { get; } = new List<Movimiento>();

    public virtual ICollection<PagosCliente> PagosClientes { get; } = new List<PagosCliente>();

    public virtual ICollection<Retencione> Retenciones { get; } = new List<Retencione>();

    public virtual ICollection<UnidadesNegociosTipoMovimiento> UnidadesNegociosTipoMovimientos { get; } = new List<UnidadesNegociosTipoMovimiento>();
}
