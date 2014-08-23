using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = string.Format("{0} {1} {2}", controller, action, id);
            ViewBag.Message = message;

            return View();
        }

        public ActionResult About()
        {
            //instancio un modelo nuevo de AboutModel()
            var model = new AboutModel();
            //Asigno valores a las propiedades del Modelo
            model.Nombre = "Nimia";
            model.Ubicacion = "Asuncion";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
