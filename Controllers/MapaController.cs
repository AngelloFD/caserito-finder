using Microsoft.AspNetCore.Mvc;

namespace caserito_finder.Controllers
{
    public class MapaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
