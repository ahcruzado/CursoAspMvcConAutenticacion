using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoAspMvcConAutenticacion.Controllers
{
    public class HomeController : Controller
    {

        //Action para descargar archivo
        //public FileResult Index()
        //{
        //    var path = Server.MapPath("SaldosBancarios20191206.pdf");
        //    return File(path, "application/pdf", "NombreAMostrar.pdf");
        //    //return View();
        //}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[HttpGet]
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Contact(int edad)
        //{
        //    ViewBag.Message = "Your contact page." + " Edad = " + edad.ToString();
        //    ViewBag.Edad = edad;

        //    return View();
        //}
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.UnInt = 45;
            ViewBag.UnaFecha = new DateTime(1800, 4, 7);
            ViewData["MiMensaje"] = "Esto fue con ViewData";

            return View();
        }

        public ActionResult MiAction()
        {
            return View();
        }
    }
}