using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }

        /*
        public DateTime Anio { get; set; }
        public DateTime Mes { get; set; }
        public DateTime Dia { get; set; }
        */
        public float Importe { get; set; }

        public Sueldo Sueldo { get; set; }
        public int SueldoId { get; set; }
        //public ICollection<Factura> Facturas { get; set; }
        /*
        public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
        */
    }
}
