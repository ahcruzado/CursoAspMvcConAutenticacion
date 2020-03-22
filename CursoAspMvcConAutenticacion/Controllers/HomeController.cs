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
            ViewBag.MiListado=ObtenerListado();
            return View();
        }

        public List<SelectListItem> ObtenerListado()
        {
            var listado = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text= "Sí",
                    Value="1"
                },
                new SelectListItem()
                {
                    Text= "No",
                    Value="2"
                },
                new SelectListItem()
                {
                    Text= "Quizás",
                    Value="3"
                }
            };
            return listado;
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