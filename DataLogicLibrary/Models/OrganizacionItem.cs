using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class OrganizacionItem
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string RequiereCantidad { get; set; } = null!;
}
