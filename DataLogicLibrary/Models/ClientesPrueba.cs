using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ClientesPrueba
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public string? Persona { get; set; }

    public string? Tel { get; set; }

    public string? Mail { get; set; }

    public string? Organizacion { get; set; }

    public int? Propietario { get; set; }
}
