using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Grabar grabar = new Grabar();
            grabar.DatosIni();
            
            using (var db = EvaluacionBuilder.Crear())
            {
                /*
                var facturas = db.Facturas.FirstOrDefault();
                var cargoS = db.Cargos.FirstOrDefault();
                */
                var f = db.Facturas
                .Include(fac => fac.Sueldo)
                .Single(fac => fac.SueldoId == 1)
                ;

                var c = db.Cargos
                    .Include(carg => carg.Sueldo)
                    .Single(carg => carg.SueldoId == 1)
                    ;
                var s = db.Sueldos
                    .Single(s => s.SueldoId == 1)
                    ;

                var calS = new CalculoSueldos(c, f);
                var sueldo = calS.Sueldo(s);

                Console.WriteLine(calS.Sueldo(s));

                calS.Aprobado(f);

                //verificar si es acreedor al bono de Empleado
                Console.WriteLine(calS.Aprobado(f));

                if (calS.Aprobado(f))
                {
                    sueldo = sueldo + 150;
                }
                else
                {
                    sueldo = sueldo - 1000;
                }

                Console.WriteLine(sueldo);
            }

            /*
                using ( Repositorio db = new Repositorio())
            {
                var facturas = db.Facturas.FirstOrDefault();
                var cargoS = db.Cargos.FirstOrDefault();

                var f = db.Facturas
                .Include(fac => fac.Sueldo)
                .Single(fac => fac.SueldoId == 1)
                ;

                var c = db.Cargos
                    .Include(carg => carg.Sueldo)
                    .Single(carg => carg.SueldoId == 1)
                    ;
                var s = db.Sueldos
                    .Single(s => s.SueldoId == 1)
                    ;

                var calS = new CalculoSueldos(c, f);
                var sueldo = calS.Sueldo(s);

                Console.WriteLine(calS.Sueldo(s));

                calS.Aprobado(f);

                //verificar si es acreedor al bono de Empleado
                Console.WriteLine(calS.Aprobado(f));

                if (calS.Aprobado(f))
                {
                    sueldo = sueldo + 150;
                }
                else
                {
                    sueldo = sueldo - 1000;
                }

                Console.WriteLine(sueldo);

            }
            */
            

            //Creacion de Departamentos

            /*
            Departamento Ventas = new Departamento()
            {
                Nombre = "Ventas"
            };

            //Creacion de Sucursales
            Sucursal Sucursal1 = new Sucursal() 
            {
                Nombre = "Sucursal Sur",
                Direccion = "Av. Villaflora"
            };

            Sucursal Sucursal2 = new Sucursal()
            {
                Nombre = "Sucursal Norte",
                Direccion = "Av. Galo Plaza"
            };

            //Control Asistencia
            Control_Asistencia control_Asistencia = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now,
                Permisos = new List<Permiso>(),
                Empleados = new List<Empleado>()
            };

            //DesempenoEm
            DesempenoEm desempenoE = new DesempenoEm()
            {
                Nombre = "Bueno",
                Calificacion = "BN",
                Empleados = new List<Empleado>()
            };

            //DesempenoSc
            DesempenoSc desempenoSc = new DesempenoSc()
            { 
                Nombre = "Excelente",
                Calificacion = "EX",
                Empleados=new List<Empleado>()
            };

            //Sueldo
            Sueldo sueldo1 = new Sueldo()
            {
                SueldoBase = 420.00f
            };

            //creacion de empleado

            Empleado Juan = new Empleado() { 
                Nombres="Juan", 
                Apellidos="Perez",
                Cedula=1234567890,
                Direccion="UIO",
                Telefono=12346, 
                Email="jp@gmail.com",
                Departamento = Ventas,
                Sucursal = Sucursal1,
                Control_Asistencia=control_Asistencia,
                DesempenoEm = desempenoE,
                DesempenoSc=desempenoSc,
                Sueldo = sueldo1,
                Aumentos = new List<Aumento>()
            };
            
            /*
            Empleado Andres = new Empleado()
            {
                Nombres = "Andres",
                Apellidos = "Simba",
                Cedula = 1234567891,
                Direccion = "GYE",
                Telefono = 12347,
                Email = "as@gmail.com",
                Departamento= Ventas,
                Sucursal= Sucursal2
            };
            */

            
            //Ventas.ListaEmDep = new List<Empleado>() { Juan, Andres};


            //Repositorio db = new Repositorio();
            //db.Departamentos.Add(Ventas);
            //db.Sucursals.Add(Sucursal1);
            //db.Sucursals.Add(Sucursal2);
           // db.Empleados.Add(Juan);
            //db.Empleados.Add(Andres);
           // db.SaveChanges();
            
        }
    }
}
