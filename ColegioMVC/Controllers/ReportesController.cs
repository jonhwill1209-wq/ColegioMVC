using ColegioMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ColegioMVC.Controllers
{
    public class ReportesController : Controller
    {
        private readonly ColegioContext _context;

        public ReportesController(ColegioContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Promedios()
        {
            var promedios = await _context.Expediente
                .Include(e => e.Alumno)
                .GroupBy(e => e.Alumno.Nombre)
                .Select(g => new
                {
                    Alumno = g.Key,
                    Promedio = g.Average(x => x.NotaFinal)
                })
                .ToListAsync();

            return View(promedios);
        }
    }
}