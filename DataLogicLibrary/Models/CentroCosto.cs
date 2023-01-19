using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class CentroCosto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ComprobantesProveedoresDetalle> ComprobantesProveedoresDetalles { get; } = new List<ComprobantesProveedoresDetalle>();
}
