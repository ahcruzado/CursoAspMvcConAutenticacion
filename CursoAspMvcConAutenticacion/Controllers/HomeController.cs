using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
       
    }

    public class Persona
    {
        [Required(AllowEmptyStrings =false)]
        public string Nombre { get; set; }

        [Range(1,99)]
        public int Edad { get; set; }
    }


}