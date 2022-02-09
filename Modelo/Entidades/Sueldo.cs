using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Sueldo
    {
        public int SueldoId { get; set; }
        public float SueldoBase { get; set; }
        
       /* public Cargo CargoS { get; set; }
        public int CargoId { get; set; }
        */
        public int FacturasId { get; set; }
       /* public Bono Bonos { get; set; }
        public int BonoId { get; set; }
       */
        
        public ICollection<Empleado> Empleados { get; set; }
        public ICollection<Factura> Facturas { get; set; }
        public ICollection<Cargo> Cargos { get; set; }
        //public ICollection<Bono> Bonos { get; set; }

    }
}
