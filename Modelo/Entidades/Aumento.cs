using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Aumento
    {
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
        public Bono Bono { get; set; }
        public int BonoId { get; set; }
    }
}
