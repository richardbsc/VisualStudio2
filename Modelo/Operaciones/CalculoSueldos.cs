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
            //10000
            this.bempleado = 500;
        }      

        public bool Aprobado(Factura factura)
        {
            return factura.Importe >= bempleado;
        }

        public float Sueldo(Sueldo sueldo)
        {
            float sueldoFinal;

            sueldoFinal = salario + facturas + sueldo.SueldoBase;

            return sueldoFinal;
        }

    }
}
