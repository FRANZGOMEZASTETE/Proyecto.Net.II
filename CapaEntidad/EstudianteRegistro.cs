using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EstudianteRegistro
    {
        public int Id { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public TimeSpan Hora_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public TimeSpan Hora_Salida { get; set; }
        public string DNI { get; set; }
    }
}
