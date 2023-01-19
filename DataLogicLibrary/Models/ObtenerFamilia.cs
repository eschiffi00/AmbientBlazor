using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerFamilia
{
    public int GrupoId { get; set; }

    public int CategoriaItemId { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Subtitulo { get; set; }

    public string Comentario { get; set; } = null!;

    public string? Edad { get; set; }

    public string Fantasia { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
