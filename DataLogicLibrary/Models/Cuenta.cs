using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Cuenta
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string TipoCuenta { get; set; } = null!;

    public int MonedaId { get; set; }

    public int? EmpresaId { get; set; }

    public virtual ICollection<ComprobantesProveedore> ComprobantesProveedores { get; } = new List<ComprobantesProveedore>();

    public virtual ICollection<CuentasLog> CuentasLogs { get; } = new List<CuentasLog>();

    public virtual Empresa? Empresa { get; set; }

    public virtual Moneda Moneda { get; set; } = null!;

    public virtual ICollection<PagosProveedore> PagosProveedores { get; } = new List<PagosProveedore>();
}
