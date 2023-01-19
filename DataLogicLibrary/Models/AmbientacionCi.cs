using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class AmbientacionCi
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Flete { get; set; }

    public int EstadoId { get; set; }

    public virtual ICollection<CostosPaquetesCiambientacion> CostosPaquetesCiambientacions { get; } = new List<CostosPaquetesCiambientacion>();
}
