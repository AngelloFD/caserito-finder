using Microsoft.AspNetCore.Mvc;

namespace caserito_finder.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Usuario(String nombreNegocio, String duenoNegocio, String direccion, String email, int telefono)
        {
            ViewData["nombreNegocio"] = nombreNegocio;
            ViewData["duenoNegocio"] = duenoNegocio;
            ViewData["direccion"] = direccion;
            ViewData["email"] = email;
            ViewData["telefono"] = telefono;

            return View();
        }
    }


}