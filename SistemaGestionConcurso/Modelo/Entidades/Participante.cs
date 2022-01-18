using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Participante
    {
        public int ParticipanteId { get; set; } 
        public string NombreParticipante { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string Correo { get; set; }

    }
}
