using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Control_Asistencia
    {
        public int Control_AsistenciaId { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime Ingreso { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime SalidaAlmuerzo { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EntradaAlmuerzo { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Salida { get; set; }
        //public string Permiso { get; set; }

        //public Horario_Det Horario_Det{ get; set; }
       
        public ICollection<Permiso> Permisos  { get; set; }

        public ICollection<Empleado> Empleados { get; set; }
    }
}
