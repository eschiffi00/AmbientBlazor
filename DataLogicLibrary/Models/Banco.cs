using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class Banco
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Cheque> Cheques { get; } = new List<Cheque>();

    public virtual ICollection<Transferencia> Transferencia { get; } = new List<Transferencia>();
}
