using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuela
{
    class Directivo:Empleado
    {
        public string numNomina { get; set; }
        public string gradEstudios { get; set; }
        public string direccion { get; set; }
        public string puestoJefatura { get; set; }
        public string EmpleadosCargo { get; set; }
    }
}
