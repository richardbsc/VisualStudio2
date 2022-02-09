using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamendoId { get; set; }
        public Sucursal Sucursal { get; set; }
        public int SucursalId { get; set; }
        public Control_Asistencia Control_Asistencia { get; set; }
        public int Control_AsistenciaId { get; set; }

        public Sueldo Sueldo { get; set; }
        public int SueldoId { get; set; }

        public DesempenoEm DesempenoEm { get; set; }
        public int DesempenoEmId { get; set; }
        public DesempenoSc DesempenoSc { get; set; }
        public int DesempenoScId { get; set; }
        public ICollection<Aumento> Aumentos { get; set; }

        /*
        public Cargo Cargos { get; set; }
        public int CargoId { get; set; }
        public Factura Facturas { get; set; }
        public int FacturaId { get; set; }
        public Permiso Permisos { get; set; }
        public int PermisoId { get; set; }
        
        public Desempeno DesempenosA { get; set; }
        public int DesempenoId { get; set; }
        public Bono Bonos { get; set; }
        public int BonoId { get; set; }        
        public Sueldo Sueldos { get; set; }
        public int SueldoId { get; set; }
        */
    }
}
