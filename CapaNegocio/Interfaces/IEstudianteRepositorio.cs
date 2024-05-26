using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    internal interface IEstudianteRepositorio
    {
        void Agregar(Estudiante estudiante);
        void Actualizar(Estudiante estudiante);
        List<Estudiante> ListarEstudiante();
        Estudiante Buscar(int Id);
        List<Estudiante> ListarEstudianteXNombre(string Nombre);
    }
}
