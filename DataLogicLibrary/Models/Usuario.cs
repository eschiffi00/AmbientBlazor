using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string LoginName { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Email { get; set; } = null!;

    public string? Password { get; set; }

    public DateTime FeCreacion { get; set; }

    public int NroDeFallos { get; set; }

    public int EsAdmin { get; set; }

    public int EstadoId { get; set; }

    public int UsuarioIdCreador { get; set; }

    public virtual ICollection<UsuarioRol> UsuarioRols { get; } = new List<UsuarioRol>();
}
