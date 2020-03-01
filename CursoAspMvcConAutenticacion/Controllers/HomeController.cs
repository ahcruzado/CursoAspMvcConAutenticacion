using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoAspMvcConAutenticacion.Controllers
{
    public class HomeController : Controller
    {
        private PeliculasRepository peliculasRepository;

        public HomeController()
        {
            peliculasRepository = new PeliculasRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = peliculasRepository.ObtenerPeliculas();
            return View(model);
        }

    }
}