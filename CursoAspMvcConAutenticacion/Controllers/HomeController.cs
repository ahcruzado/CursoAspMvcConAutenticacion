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
            var persna = new Persona()
            {
                Nombre = "Claudia",
                Edad = 35,
                Empleado=true,
                Nacimiento=new DateTime(2015,01,23)
            };
            ViewBag.Propiedad = persna;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        [ChildActionOnly]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var model = peliculasRepository.ObtenerPeliculas();
            return View(model);
        }

    }

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Empleado { get; set; }
        public DateTime Nacimiento { get; set; }

    }
}