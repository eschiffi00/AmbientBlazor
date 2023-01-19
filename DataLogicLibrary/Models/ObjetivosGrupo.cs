using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObjetivosGrupo
{
    public int Id { get; set; }

    public int GrupoId { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public double Facturacion { get; set; }

    public int CantidadAperturas { get; set; }

    public virtual UsuariosGrupo Grupo { get; set; } = null!;
}
