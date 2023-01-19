using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class UnidadesNegocio
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Adicionale> Adicionales { get; } = new List<Adicionale>();

    public virtual ICollection<ComprobantesProveedoresDetalle> ComprobantesProveedoresDetalles { get; } = new List<ComprobantesProveedoresDetalle>();

    public virtual ICollection<Intermediario> Intermediarios { get; } = new List<Intermediario>();

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();

    public virtual ICollection<TipoCatering> TipoCaterings { get; } = new List<TipoCatering>();

    public virtual ICollection<TipoServicio> TipoServicios { get; } = new List<TipoServicio>();

    public virtual ICollection<UnidadesNegociosProveedore> UnidadesNegociosProveedores { get; } = new List<UnidadesNegociosProveedore>();

    public virtual ICollection<UnidadesNegociosTipoMovimiento> UnidadesNegociosTipoMovimientos { get; } = new List<UnidadesNegociosTipoMovimiento>();
}
