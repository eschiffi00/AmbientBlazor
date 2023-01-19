using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ReporteEventosCobranza
{
    public int PresupuestoId { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public int? TotalInvitados { get; set; }

    public string? UnidadDeNegocio { get; set; }

    public string UnidadNegocioAdicional { get; set; } = null!;

    public string PrecioSeleccionado { get; set; } = null!;

    public string? RazonSocial { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? Locacion { get; set; }

    public int? Aniosenia { get; set; }

    public int? Messenia { get; set; }

    public int? Diasenia { get; set; }

    public string? Ejecutivo { get; set; }

    public double Comision { get; set; }

    public double Cannon { get; set; }

    public double Logistica { get; set; }

    public double Fee { get; set; }

    public double Organizador { get; set; }

    public double Descuentos { get; set; }

    public double Incrementos { get; set; }

    public double? CostoTotal { get; set; }

    public double? PrecioTotal { get; set; }

    public double? TotalPresupuestoSinIndexacion { get; set; }

    public double TotalPagado { get; set; }

    public double? ValorComisionable { get; set; }
}
