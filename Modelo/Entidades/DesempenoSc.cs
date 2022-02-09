using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class DesempenoSc
    {
        public int DesempenoScId { get; set; }
        public string Nombre { get; set; }
        public string Calificacion { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
