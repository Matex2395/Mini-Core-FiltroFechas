using System;
using System.Collections.Generic;

namespace Mini_Core_FiltroFechas.Models;

public partial class Gasto
{
    public int GastoId { get; set; }

    public DateOnly GastoFecha { get; set; }

    public string? GastoDescripcion { get; set; }

    public decimal GastoMonto { get; set; }

    public int? GastoEmpleadoId { get; set; }

    public int? GastoDepartamentoId { get; set; }

    public virtual Departamento? GastoDepartamento { get; set; }

    public virtual Empleado? GastoEmpleado { get; set; }
}
