using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Retencione
{
    public int Id { get; set; }

    public int? PagoProveedorId { get; set; }

    public int? PagoClienteId { get; set; }

    public string NroCertificado { get; set; } = null!;

    public int TipoMovimimientoId { get; set; }

    public DateTime Fecha { get; set; }

    public double Importe { get; set; }

    public DateTime CreateFecha { get; set; }

    public DateTime? UpdateFecha { get; set; }

    public bool Delete { get; set; }

    public DateTime? DeleteFecha { get; set; }

    public virtual PagosCliente? PagoCliente { get; set; }

    public virtual PagosProveedore? PagoProveedor { get; set; }

    public virtual TipoMovimiento TipoMovimimiento { get; set; } = null!;
}
