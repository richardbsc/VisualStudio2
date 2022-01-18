using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Calificacion
    {
        public int CalificacionId { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float NotaFinal { get; set; }
    }
}
