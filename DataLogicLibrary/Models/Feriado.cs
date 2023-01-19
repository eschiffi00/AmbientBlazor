using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Feriado
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public string? Descripcion { get; set; }

    public int Anio { get; set; }

    public DateTime? SePasaA { get; set; }
}
