using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoAspMvcConAutenticacion.Models
{
    public class Pelicula
    {
        public int Id { get; set;}

        public string Titulo { get; set; }

        public bool EstaEnCartera { get; set; }
        
        public string Genero { get; set; }
    }
}