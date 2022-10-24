using Microsoft.AspNetCore.Mvc;

namespace caserito_finder.Controllers
{
    public class NovedadesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
