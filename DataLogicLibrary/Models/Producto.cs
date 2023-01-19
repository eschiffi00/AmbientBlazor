using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public double Precio { get; set; }

    public double? Margen { get; set; }

    public double Costo { get; set; }

    public int UnidadNegocioId { get; set; }

    public int Estado { get; set; }

    public DateTime? FechaVendimiento { get; set; }

    public int? PerfilId { get; set; }

    public int? TipoCateringId { get; set; }

    public int? AdicionalId { get; set; }

    public int? TipoBarraId { get; set; }

    public int? TipoServicioId { get; set; }

    public int? CantidadInvitados { get; set; }

    public int? LocacionId { get; set; }

    public int? ProveedorId { get; set; }

    public int? SegmentoId { get; set; }

    public int? JornadaId { get; set; }

    public int? SectorId { get; set; }

    public int? CategoriaId { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public string? Dia { get; set; }

    public int? CaracteristicaId { get; set; }

    public int? OrganizacionItemId { get; set; }

    public int? Semestre { get; set; }

    public double? MargenAjuste { get; set; }

    public double Royalty { get; set; }

    public double? Margen2 { get; set; }

    public virtual Perfile? Perfil { get; set; }

    public virtual UnidadesNegocio UnidadNegocio { get; set; } = null!;
}
