using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ReporteEventosPorUnidadesdeNegocio
{
    public int NroCliente { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? RazonSocial { get; set; }

    public string? Mail { get; set; }

    public string? Celular { get; set; }

    public string ComoLlego { get; set; } = null!;

    public int NroEvento { get; set; }

    public string Caracteristica { get; set; } = null!;

    public string Segmento { get; set; } = null!;

    public string Locacion { get; set; } = null!;

    public string? Sector { get; set; }

    public string Jornada { get; set; } = null!;

    public string? HorarioEvento { get; set; }

    public int? CantidadInicialInvitados { get; set; }

    public int CantidadInvitadosAdolecentes { get; set; }

    public int CantidadInvitadosMenores3y8 { get; set; }

    public int CantidadInvitadosMenores3 { get; set; }

    public DateTime? FechaEvento { get; set; }

    public string Estado { get; set; } = null!;

    public string? Ejecutivo { get; set; }

    public int NroPresupuesto { get; set; }

    public DateTime FechaEnvioPresupuesto { get; set; }

    public string EstadoPresupuesto { get; set; } = null!;

    public double? TotalSalon { get; set; }

    public string? ValorVendidoSalon { get; set; }

    public double? DescuentoSalon { get; set; }

    public double? TotalCatering { get; set; }

    public double? CostoCanon { get; set; }

    public double? CostoLogistica { get; set; }

    public string? ValorVendidoCatering { get; set; }

    public string? TipoCatering { get; set; }

    public double? DescuentoCatering { get; set; }

    public double? TotalTecnica { get; set; }

    public string? ValorVendidoTecnica { get; set; }

    public string? TipoTecnica { get; set; }

    public double? DescuentoTecnica { get; set; }

    public double? TotalBarra { get; set; }

    public double? CostoCanonBarras { get; set; }

    public double? CostoLogisticaBarra { get; set; }

    public string? ValorVendidoBarra { get; set; }

    public string? TipoBarra { get; set; }

    public double? DescuentoBarra { get; set; }

    public double? TotalAmbientacion { get; set; }

    public string? ValorVendidoAmbientacion { get; set; }

    public double? DescuentoAmbientacion { get; set; }

    public double? TotalAudiovisual { get; set; }

    public string? ValorVendidoAudiovisual { get; set; }

    public double? DescuentoAudiovisual { get; set; }

    public double? TotalArtistica { get; set; }

    public string? ValorVendidoArtistica { get; set; }

    public double? DescuentoArtistica { get; set; }

    public double? TotalAdicionales { get; set; }

    public double? PrecioTotal { get; set; }

    public double? PrecioPorPersona { get; set; }

    public DateTime? FechaAprobacion { get; set; }
}
