using CadeteriaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadeteriaMVC.Controllers
{
    public class CadetesController : Controller
    {
        private readonly ILogger<CadetesController> _logger;
        private readonly static List<Cadete> ListaDeCadetes = new();

        public CadetesController(ILogger<CadetesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Listado()
        {
            return View(ListaDeCadetes);
        }

        public IActionResult Alta()
        {
            return View();
        }

        public IActionResult Baja(int Id)
        {
            return View(Id);
        }

        [HttpPost]
        public IActionResult AltaOk(string Nombre, string Direccion, ulong Telefono)
        {
            Cadete Cadete = new Cadete(Nombre, Direccion, Telefono);
            ListaDeCadetes.Add(Cadete);
            return RedirectToAction("Listado");
        }

        [HttpPost]
        public IActionResult BajaOk(int Id)
        {
            ListaDeCadetes.RemoveAll(i => i.GetId() == Id);
            return RedirectToAction("Listado");
        }
    }
}
