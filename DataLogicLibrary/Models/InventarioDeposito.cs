using System;
using System.Collections.Generic;

namespace DataLogicLibrary.Models;

public partial class InventarioDeposito
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool Delete { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<InventarioProductoDeposito> InventarioProductoDepositos { get; } = new List<InventarioProductoDeposito>();
}
