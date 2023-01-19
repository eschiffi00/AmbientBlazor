using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class UsuariosLocacione
{
    public int Id { get; set; }

    public int? EmpleadoId { get; set; }

    public int? LocacionId { get; set; }
}
