using ConsoleApp;
using Microsoft.EntityFrameworkCore;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvaluacion
{
    public sealed class DBBuilder
    {
        private DBBuilder() { }
        private static Repositorio db;

        public static Repositorio GetDB()
        {
            if( db == null)
            {
                Grabar grabar = new Grabar();
                grabar.DatosIni();
                db = EvaluacionBuilder.Crear();
            }
            return db;
        }

    }
}
