﻿using System;
using System.Collections.Generic;

namespace Core.Ventas.Models;

public partial class Local
{
    public long IdLocal { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
