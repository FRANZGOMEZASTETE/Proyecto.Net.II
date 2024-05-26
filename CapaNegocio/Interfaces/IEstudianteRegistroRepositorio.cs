﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interfaces
{
    internal interface IEstudianteRegistroRepositorio
    {
        void RegistrarEntradaEstudiante(string dni);
        void RegistrarSalidaEstudiante(string dni);
    }
}
