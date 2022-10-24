using Microsoft.AspNetCore.Mvc;

namespace caserito_finder.Controllers
{
    public class AcercaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
