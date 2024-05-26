using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    internal interface IDocenteRepositorio
    {
        void Agregar(Docente docente);
        void Actualizar(Docente docente);
        List<Docente> ListarDocente();
        Docente Buscar(int Id);
        List<Docente> ListarDocenteXNombre(string Nombre);
    }
}
