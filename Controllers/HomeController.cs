using caserito_finder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace caserito_finder.Controllers
{
    public class HomeController : Controller
    {
        private readonly bd_proyectoContext context;

        public HomeController(bd_proyectoContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
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

        public IActionResult SesionIniciada()
        {
            return View();
        }

        [Route("Home/EditarSesion/{codigo}")]
        public IActionResult EditarSesion(int codigo)
        {
            var objForm = (from Talu in context.Forms
                           where Talu.Id == codigo
                           select Talu).Single();

            ViewData["nomNego"]=objForm.NombreNegocio;
            ViewData["dueNego"] = objForm.DueñoNegocio;
            ViewData["direNego"] = objForm.Direccion;
            ViewData["email"] = objForm.Email;
            ViewData["telf"] = objForm.Telefono;
            ViewData["desde"] = objForm.Desde;
            ViewData["hasta"] = objForm.Hasta;
            return View();
        }

        public IActionResult EditarNuevo(Form objNew)
        {
            if (ModelState.IsValid)
            {
                var ObjOld = (from Talu in context.Forms
                              where Talu.Id == objNew.Id
                              select Talu).Single();

                ObjOld.NombreNegocio = objNew.NombreNegocio;
                ObjOld.DueñoNegocio = objNew.DueñoNegocio;
                ObjOld.Direccion = objNew.Direccion;
                ObjOld.Email = objNew.Email;
                ObjOld.Telefono = objNew.Telefono;
                ObjOld.Desde = objNew.Desde;
                ObjOld.Hasta = objNew.Hasta;

                context.SaveChanges();
                return RedirectToAction("EditarSesion");
            }
            else
            {
                return View("EditarSesion");
            }
        }

        [Route("Home/EliminarSesion/{codigo}")]
        public IActionResult EliminarSesion(int codigo)
        {
            var objForm = (from Talu in context.Forms where Talu.Id == codigo
                          select Talu).Single();
            context.Forms.Remove(objForm);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult CreateCaserito(Form objForm)
        {
            if (ModelState.IsValid)
            {
                context.Forms.Add(objForm);
                context.SaveChanges();
                return RedirectToAction("SesionIniciada");
            }
            else
            {
                return View("Index");
            }
        }
    }
}