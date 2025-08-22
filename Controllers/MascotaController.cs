using Microsoft.AspNetCore.Mvc;
using VeterinariaApp.Models;

namespace VeterinariaApp.Controllers
{
    public class MascotaController : Controller
    {
        private static List<Mascota> _mascotas = new List<Mascota>();

        public IActionResult Index()
        {
            return View(_mascotas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mascota mascota)
        {
            _mascotas.Add(mascota);
            return RedirectToAction("Index");
        }
    }
}
