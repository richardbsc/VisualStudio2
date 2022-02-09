using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nombre { get; set; }
        public float Salario { get; set; }
        public Sueldo Sueldo { get; set; }
        public int SueldoId { get; set; }

        //public ICollection<Sueldo> Sueldos { get; set; }
    }
}
