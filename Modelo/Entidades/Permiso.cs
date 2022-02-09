using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Permiso
    {
        public int PermisoId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Horario_Det Horario_Det { get; set; }
        public int Horario_DetId { get; set; }

        public Control_Asistencia Control_Asistencia { get; set; }
        public int Control_AsistenciaId { get; set; }
        
    }
}
