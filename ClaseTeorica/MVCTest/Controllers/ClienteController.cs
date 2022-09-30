using Microsoft.AspNetCore.Mvc;
using MVCTest.Models;
namespace MVCTest.Controllers
{
    public class ClienteController : Controller
    {
        //public string ConsultaCliente(int id, string name)
        //{
        //    return $"Cliente [{id}] - {name}";
        //}
        public IActionResult ConsultaCliente()
        {
            var miCliente = new Cliente();
            miCliente.Name = "Minombre";
            miCliente.Edad = 15;
            return View(miCliente);
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AltaCliente(Cliente cliente)
        {
            return RedirectToAction("Index");
        }
    }
}
