using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace ConsoleApp
{
    public class EvaluacionBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, MySql, Memoria }
        static Repositorio db;

        public static Repositorio Crear()
        {
            string dbtipo;
            string conn;

            dbtipo = ConfigurationManager.AppSettings[DBTipo];

            if (dbtipo == null)
            {
                dbtipo = "Memoria";
                conn = "SEP_DBMemoria";
            }
            else
            {
                conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;
            }

            
            //Console.WriteLine(serverVersion);

            // Construye la conección acorde con el tipo
            DbContextOptions<Repositorio> contextOptions;
            switch (dbtipo)
            {
                case nameof(DBTipoConn.SqlServer):
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.Postgres):
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.MySql):
                    var serverVersion = ServerVersion.AutoDetect(conn);
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseMySql(conn, serverVersion)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new Repositorio(contextOptions);

            return db;
        }

        

        


    }
}
