using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Docente
    {
        public int Id { get; set; }
        public string Num_doc { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
    }
}
