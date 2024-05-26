﻿using CapaDatos;
using CapaEntidad;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EstudianteNegocio : IEstudianteRepositorio
    {
        ProyectoContextoDB db = new ProyectoContextoDB();

        public void Actualizar(Estudiante estudiante)
        {
            db.Entry(estudiante).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(Estudiante estudiante)
        {
            db.Estudiante.Add(estudiante);
            db.SaveChanges();
        }

        public Estudiante Buscar(int Id)
        {
            var busqueda = db.Estudiante.Find(Id);
            return busqueda;
        }

        public List<Estudiante> ListarEstudiante()
        {
            var query = from x in db.Estudiante
                        orderby x.Id
                        select x;
            return query.ToList();
            //return db.Estudiante.ToList();
        }

        public List<Estudiante> ListarEstudianteXNombre(string Nombre)
        {
            var query = from x in db.Estudiante
                        orderby x.Nombre.Contains(Nombre)
                        select x;
            return query.ToList();
            //return db.Estudiante.ToList(); 
        }
    }
}
