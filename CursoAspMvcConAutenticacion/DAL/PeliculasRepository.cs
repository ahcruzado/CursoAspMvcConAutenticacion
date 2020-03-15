using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoAspMvcConAutenticacion
{
    public class PeliculasRepository
    {
        public List<Models.Pelicula> ObtenerPeliculas()
        {
            return new List<Models.Pelicula>()
            {
                new Models.Pelicula()
                {
                    Titulo= "Pete's Dragon",
                    EstaEnCartera=true,
                    Genero = "Fantasía"
                },
                new Models.Pelicula()
                {
                    Titulo= "<b>Mechanic: Resurrection</b>",
                    EstaEnCartera=true,
                    Genero = "Acción"
                },
                new Models.Pelicula()
                {
                    Titulo= "Deadpool",
                    EstaEnCartera=false,
                    Genero = "Acción"
                }
            };
        }
    }
}