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

        [Required(AllowEmptyStrings =false)]
        public string Titulo { get; set; }

        public bool EstaEnCartera { get; set; }

        [StringLength(120)]
        public string Genero { get; set; }
    }
}