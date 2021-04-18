using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscuela
{
    class Administrativo:Empleado
    {
        public int numEmpleado { get; set; }
        public string departamentoAdscripcion { get; set; }
        public string direccion { get; set; }
        public string seguroSocial { get; set; }
        public string correo { get; set; }
    }
}
