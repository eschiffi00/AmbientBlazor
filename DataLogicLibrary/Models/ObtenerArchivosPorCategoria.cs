using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class ObtenerArchivosPorCategoria
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte[]? Archivo { get; set; }

    public string? ExtencionArchivo { get; set; }

    public int? CategoriaArchivoId { get; set; }

    public int? CarpetaId { get; set; }

    public string? Carpeta { get; set; }
}
