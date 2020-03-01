using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoAspMvcConAutenticacion.Models
{
    public class Pelicula
    {

        public string Titulo { get; set; }
        public bool EstaEnCartera { get; set; }
        public string Genero { get; set; }
    }
}