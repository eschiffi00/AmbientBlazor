using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CuentasLog
{
    public int Id { get; set; }

    public int CuentaId { get; set; }

    public string? Descripcion { get; set; }

    public double SaldoAnterior { get; set; }

    public double SaldoActual { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public int UsuarioId { get; set; }

    public int? PagoClienteId { get; set; }

    public int? PagoProveedorId { get; set; }

    public int? TipoMovimientoId { get; set; }

    public double? TipoCambio { get; set; }

    public virtual Cuenta Cuenta { get; set; } = null!;
}
