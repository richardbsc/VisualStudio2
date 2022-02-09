using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Sucursal
    {
        public int SucursalId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        /*public Empleado Empleado { get; set; }
        public int EmpleadoId { get; set; }
        */

        public ICollection<Empleado> Empleados { get; set; }

        /*
        public DesempenoSc DesempenosB { get; set; }
        public int DesempenoId { get; set; }
        */

    }
}
