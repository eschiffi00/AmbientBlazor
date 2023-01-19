using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class PagosCliente
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int EmpresaId { get; set; }

    public int? ProveedorCannonId { get; set; }

    public int FormadePagoId { get; set; }

    public int TipoMovimientoId { get; set; }

    public DateTime FechaPago { get; set; }

    public double Importe { get; set; }

    public string? Concepto { get; set; }

    public string? NroRecibo { get; set; }

    public DateTime FechaCreate { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public bool Delete { get; set; }

    public DateTime? FechaDelete { get; set; }

    public int EmpleadoId { get; set; }

    public double? Indexacion { get; set; }

    public double? IvaPorcentaje { get; set; }

    public int CuentaId { get; set; }

    public string? TipoPago { get; set; }

    public int EstadoId { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual FormasdePago FormadePago { get; set; } = null!;

    public virtual Presupuesto Presupuesto { get; set; } = null!;

    public virtual ICollection<Retencione> Retenciones { get; } = new List<Retencione>();

    public virtual TipoMovimiento TipoMovimiento { get; set; } = null!;
}
