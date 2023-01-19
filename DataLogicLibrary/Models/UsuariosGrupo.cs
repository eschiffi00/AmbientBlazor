using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class UsuariosGrupo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ObjetivosGrupo> ObjetivosGrupos { get; } = new List<ObjetivosGrupo>();
}
