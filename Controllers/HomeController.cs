using caserito_finder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace caserito_finder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Contacto")]
        public IActionResult Contacto()
        {
            return View();
        }

        [Route("Home/Novedades")]
        public IActionResult Novedades()
        {
            return View();
        }

        [Route("Home/Mapa")]
        public IActionResult Mapa()
        {
            return View();
        }

        [Route("Home/Tienda")]
        public IActionResult Tienda()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}