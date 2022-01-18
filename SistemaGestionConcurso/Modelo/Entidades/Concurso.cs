using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Concurso
    {
        public int PostulacionId { get; set; }
        public string Estado { get; set;}
        public int ParticipanteId { get; set;}
        public string Participante { get; set; }
        public DateTime Fecha { get; set; }


    }
}
