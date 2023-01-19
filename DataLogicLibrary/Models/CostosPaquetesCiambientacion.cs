using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostosPaquetesCiambientacion
{
    public int Id { get; set; }

    public int PaqueteCiid { get; set; }

    public int SegmentoId { get; set; }

    public int CaracteristicaId { get; set; }

    public int ProveedorId { get; set; }

    public int CantidadPaquetes { get; set; }

    public int Semestre { get; set; }

    public int Anio { get; set; }

    public double Precio { get; set; }

    public double Costo { get; set; }

    public double Margen { get; set; }

    public double CostoFlete { get; set; }

    public virtual Caracteristica Caracteristica { get; set; } = null!;

    public virtual AmbientacionCi PaqueteCi { get; set; } = null!;

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual Segmento Segmento { get; set; } = null!;
}
