using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Familia
{
    public int GrupoId { get; set; }

    public int CategoriaItemId { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Subtitulo { get; set; }

    public string Comentario { get; set; } = null!;

    public string? Edad { get; set; }

    public string Fantasia { get; set; } = null!;

    public virtual CategoriasItem CategoriaItem { get; set; } = null!;

    public virtual GruposItem Grupo { get; set; } = null!;
}
