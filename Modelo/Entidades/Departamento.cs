﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }

        public List<Empleado> Empleados{ get; set; }

    }
}
