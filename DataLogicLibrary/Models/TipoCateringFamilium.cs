using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class TipoCateringFamilium
{
    public int Id { get; set; }

    public int GrupoId { get; set; }

    public int? TipoCateringId { get; set; }

    public int? AdicionalId { get; set; }
}
