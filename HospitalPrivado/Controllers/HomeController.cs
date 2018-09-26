using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalPrivado.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Informacion del Hospital";

            return View();
        }

        public ActionResult Contacto()
        {
            ViewBag.Message = "Contacto de Pagina";

            return View();
        }

        public ActionResult Singin()
        {
            ViewBag.Message = "Registrate para tener beneficios";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Sigue los beneficios que tenemos para ti";

            return View();
        }

		public ActionResult Beneficios()
		{
			ViewBag.Message = "Los beneficios que los pacientes tienen";

			return View();
		}
	}
}