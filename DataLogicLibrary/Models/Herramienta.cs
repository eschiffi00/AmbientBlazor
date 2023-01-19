using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Herramienta
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte[]? Archivo { get; set; }

    public string? ExtencionArchivo { get; set; }

    public int? CategoriaArchivoId { get; set; }

    public virtual CategoriasArchivo? CategoriaArchivo { get; set; }
}
