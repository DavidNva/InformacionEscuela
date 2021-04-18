using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuela
{
    class Alumno:Persona
    {
        public int numControl { get; set; }
        public DateTime fecNacimiento { get; set; }
        public string genero { get; set; }
        public string edad { get; set; }
        public DateTime fecIngreso { get; set; }
        public string EstadoProcedencia { get; set; }
        public string EscuelaProcedencia { get; set; }
    }
}
