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
            ViewBag.MiListadoEnum = ToListSelectItems<Models.ResultadoOperacion>();
            return View();
        }

        private List<SelectListItem> ToListSelectItems<T>()
        {
            var t = typeof(T);

            if (!t.IsEnum) { throw new ApplicationException("La culpa es de Cabeza"); }

            var members = t.GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            var resut = new List<SelectListItem>();

            foreach (var member in members)
            {
                var attributeDescription = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                var descripcion = member.Name;

                if (attributeDescription.Any())
                {
                    descripcion = ((System.ComponentModel.DescriptionAttribute)attributeDescription[0]).Description;
                }

                var valor = ((int)Enum.Parse(t, member.Name));
                resut.Add(new SelectListItem()
                {
                    Text = descripcion,
                    Value = valor.ToString()
                });
            }

            return resut;
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