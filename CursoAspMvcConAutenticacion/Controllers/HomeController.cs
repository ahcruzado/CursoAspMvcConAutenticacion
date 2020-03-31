using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoAspMvcConAutenticacion.Controllers
{
    public class HomeController : Controller
    {        
        [HttpGet]
        public ActionResult Index()
        {
            List<Persona> personas = GetListadoPersonas();
            ViewBag.MiListado = personas;

            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            ViewBag.Message = "Exitoso";
            return View(persona);
        }
        

        public ActionResult About()
        {            
            List<Persona> personas = GetListadoPersonas();
            ViewBag.MiListado = personas;

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        private static List<Persona> GetListadoPersonas()
        {
            return new List<Persona>()
            {
                new Persona(){ Nombre= "Marcela", Edad=18},
                new Persona(){ Nombre= "Henry", Edad=40},
                new Persona(){ Nombre= "Daniela", Edad=27}
            };
        }

    }


}