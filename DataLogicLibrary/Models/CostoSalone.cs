using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CostoSalone
{
    public int Id { get; set; }

    public int LocacionId { get; set; }

    public int SectorId { get; set; }

    public int JornadaId { get; set; }

    public double PorcentajedelTotal { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public string Dia { get; set; } = null!;

    public double ValorMas5PorCiento { get; set; }

    public double ValorMenos5PorCiento { get; set; }

    public double ValorMenos10PorCiento { get; set; }

    public int? CantidadInvitados { get; set; }

    public double? Costo { get; set; }

    public double? Precio { get; set; }

    public virtual Jornada Jornada { get; set; } = null!;

    public virtual Locacione Locacion { get; set; } = null!;

    public virtual Sectore Sector { get; set; } = null!;
}
