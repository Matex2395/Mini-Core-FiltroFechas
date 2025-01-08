using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mini_Core_FiltroFechas.Data;
using Mini_Core_FiltroFechas.Models;

namespace Mini_Core_FiltroFechas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MiniCoreGastosContext _context;

        public HomeController(ILogger<HomeController> logger, MiniCoreGastosContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> FiltrarGastos(DateOnly fechaInicio, DateOnly fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                ModelState.AddModelError("", "La fecha de inicio no puede ser mayor a la fecha de fin.");
                return View();
            }

            var resultado = await _context.Gastos
                .Where(g => g.GastoFecha >= fechaInicio && g.GastoFecha <= fechaFin)
                .GroupBy(g => g.GastoDepartamento!.DepartamentoNombre)
                .Select(g => new
                {
                    Departamento = g.Key,
                    Total = g.Sum(x => x.GastoMonto)
                })
                .ToListAsync();

            ViewBag.Resultado = resultado;
            ViewBag.FechaInicio = fechaInicio;
            ViewBag.FechaFin = fechaFin;

            return View();
        }
    }
}
