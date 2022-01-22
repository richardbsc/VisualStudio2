using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio: DbContext
    {
        //Configuracion de las entidades
        public DbSet<Participante> Participantes { get; set;}
        public DbSet<Calificacion> Calificaciones { get; set;}
    }
}
