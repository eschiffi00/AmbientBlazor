using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerContactosCliente
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public string? ApellidoNombre { get; set; }

    public string? RazonSocial { get; set; }

    public string ApellidoyNombre { get; set; } = null!;

    public string? Celular { get; set; }

    public string? Mail { get; set; }
}
