using System.ComponentModel;

namespace CursoAspMvcConAutenticacion.Models
{

    public enum ResultadoOperacion
    {
        Aprobado = 1,
        Rechazado =2,            
        Pendiente =7,
        [Description("Pendiente Aprobacion")]
        PendienteAprobacion=9
    };
}
