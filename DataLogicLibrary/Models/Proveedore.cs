using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Proveedore
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string? Cuit { get; set; }

    public string? Propio { get; set; }

    public string? NombreFantasia { get; set; }

    public string? Telefono { get; set; }

    public string? Cbu { get; set; }

    public string? NroCliente { get; set; }

    public string? NroIibb { get; set; }

    public string? Localidad { get; set; }

    public string? Provincia { get; set; }

    public int? CondicionIvaId { get; set; }

    public virtual ICollection<AmbientacionSalon> AmbientacionSalons { get; } = new List<AmbientacionSalon>();

    public virtual ICollection<ComprobantesProveedore> ComprobantesProveedores { get; } = new List<ComprobantesProveedore>();

    public virtual CondicionIva? CondicionIva { get; set; }

    public virtual ICollection<CostosPaquetesCiambientacion> CostosPaquetesCiambientacions { get; } = new List<CostosPaquetesCiambientacion>();

    public virtual ICollection<Intermediario> Intermediarios { get; } = new List<Intermediario>();

    public virtual ICollection<ProveedoresFormasdePago> ProveedoresFormasdePagos { get; } = new List<ProveedoresFormasdePago>();

    public virtual ICollection<ProveedoresRetencione> ProveedoresRetenciones { get; } = new List<ProveedoresRetencione>();

    public virtual ICollection<RubrosProveedore> RubrosProveedores { get; } = new List<RubrosProveedore>();

    public virtual ICollection<TecnicaSalon> TecnicaSalons { get; } = new List<TecnicaSalon>();

    public virtual ICollection<UnidadesNegociosProveedore> UnidadesNegociosProveedores { get; } = new List<UnidadesNegociosProveedore>();
}
