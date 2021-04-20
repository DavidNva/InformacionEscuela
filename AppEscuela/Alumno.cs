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
        public string fecNacimiento { get; set; }
        public string genero { get; set; }
        public int edad { get; set; }
        public string fecIngreso { get; set; }
        public string EstadoProcedencia { get; set; }
        public string EscuelaProcedencia { get; set; }
    }
}