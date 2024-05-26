using CapaDatos;
using CapaEntidad;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EstudianteRegistroNegocio : IEstudianteRegistroRepositorio
    {
        private ProyectoContextoDB db = new ProyectoContextoDB();

        public void RegistrarEntradaEstudiante(string dni)
        {
            try
            {
                // Buscar el estudiante por su DNI
                var estudiante = db.Estudiante.FirstOrDefault(e => e.Num_doc == dni);
                if (estudiante != null)
                {
                    // Crear un nuevo registro de entrada
                    var entrada = new EstudianteRegistro
                    {
                        Fecha_Entrada = DateTime.Today,
                        Hora_Entrada = DateTime.Now.TimeOfDay,
                        DNI = dni
                    };

                    // Agregar el registro de entrada al contexto de base de datos
                    db.EstudianteRegistro.Add(entrada);
                    db.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("No se encontró un estudiante con el DNI proporcionado.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al registrar entrada del estudiante: " + ex.Message);
            }
        }

        public void RegistrarSalidaEstudiante(string dni)
        {
            try
            {
                // Buscar el estudiante por su DNI
                var estudiante = db.Estudiante.FirstOrDefault(e => e.Num_doc == dni);
                if (estudiante != null)
                {
                    // Crear un nuevo registro de entrada
                    var entrada = new EstudianteRegistro
                    {
                        Fecha_Salida = DateTime.Today,
                        Hora_Salida = DateTime.Now.TimeOfDay,
                        DNI = dni
                    };

                    // Agregar el registro de entrada al contexto de base de datos
                    db.EstudianteRegistro.Add(entrada);
                    db.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("No se encontró un estudiante con el DNI proporcionado.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al registrar entrada del estudiante: " + ex.Message);
            }
        }
    }
}
