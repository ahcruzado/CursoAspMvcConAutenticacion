using System.ComponentModel.DataAnnotations;

namespace CursoAspMvcConAutenticacion.Controllers
{
    public class Persona
    {
        [Required(AllowEmptyStrings =false)]
        public string Nombre { get; set; }

        [Range(1,99)]
        public int Edad { get; set; }
    }


}