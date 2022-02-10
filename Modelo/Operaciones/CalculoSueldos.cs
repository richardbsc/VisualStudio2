using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Operaciones
{
    public class CalculoSueldos
    {
        public float salario { get; set; }
        public float facturas { get; set; }
        public float bempleado { get; set; }
        public CalculoSueldos(Cargo cargo, Factura factura)
        {
            this.salario = cargo.Salario;
            this.facturas = factura.Importe;            
            this.bempleado = 10000;
        }      

        public bool Aprobado(Factura factura)
        {
            var fa = factura.Importe / 1.12;
            return fa >= bempleado;
        }
            
        public float Sueldo(Sueldo sueldo)
        {
            float sueldoFinal;

            var comision = (facturas/1.12f) * .01f;

            sueldoFinal = salario + comision + sueldo.SueldoBase;

            return sueldoFinal;
        }

        public float totIVA(Sueldo sueldo)
        {           

            var sin = facturas / 1.12f;          

            return sin;
        }

    }
}
