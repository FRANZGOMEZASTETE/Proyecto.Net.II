using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class ProyectoContextoDB : DbContext
    {
        public ProyectoContextoDB() : base("cadenaConexion1")
        { 
        }

        public virtual DbSet <Estudiante> Estudiante { get; set; }
        public virtual DbSet <Docente>  Docente { get; set; }
        public virtual DbSet<EstudianteRegistro> EstudianteRegistro { get; set; }
    }
}
