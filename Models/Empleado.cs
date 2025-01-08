using System;
using System.Collections.Generic;

namespace Mini_Core_FiltroFechas.Models;

public partial class Empleado
{
    public int EmpleadoId { get; set; }

    public string EmpleadoNombre { get; set; } = null!;

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();
}
