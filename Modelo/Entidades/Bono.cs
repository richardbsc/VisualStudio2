using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum BonoTipo { Empleado, Sucursal, Extra}
    public class Bono
    {
        public int BonoId { get; set; }
        public string Nombre { get; set; }

        public BonoTipo Tipo { get; set; }
        //public string Tipo { get; set; }
        public float Valor { get; set; }

        /*public Sueldo Sueldo { get; set; }
        public int SueldoId { get; set; }
        */
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
        public ICollection<Aumento> Aumentos { get; set; }

    }
}
