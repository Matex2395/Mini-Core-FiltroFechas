using System;
using System.Collections.Generic;

namespace Mini_Core_FiltroFechas.Models;

public partial class Departamento
{
    public int DepartamentoId { get; set; }

    public string DepartamentoNombre { get; set; } = null!;

    public virtual ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();
}
