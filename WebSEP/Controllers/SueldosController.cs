using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloBD;
using System.Collections.Generic;
using System.Linq;

namespace WebSEP.Controllers
{
    public class SueldosController : Controller
    {
        private readonly Repositorio db;
        public SueldosController(Repositorio db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Empleado> listaEmpleados = db.Empleados
                .Include(empleado => empleado.Sucursal)
                .Include(empleado => empleado.Departamento)
                .Include(empleado => empleado.DesempenoEm)
                .Include(empleado => empleado.DesempenoSc);

            return View(listaEmpleados);
        }
        
        public IActionResult Detalles(int id)
        {
            var sueldo = db.Sueldos
                .Include(sueldo => sueldo.Cargos)
                .Include(sueldo => sueldo.Facturas)
                .Include(sueldo => sueldo.Empleados)
                    .ThenInclude(sueldo => sueldo.Sucursal)
                .Single(sueldo => sueldo.SueldoId == id);
                ;
            
            var f = db.Facturas
                .Include(fac => fac.Sueldo)
                .Single(fac => fac.SueldoId == sueldo.SueldoId)
                ;

            var c = db.Cargos
                .Include(carg => carg.Sueldo)
                .Single(carg => carg.SueldoId == sueldo.SueldoId)
                ;

            var s = db.Sueldos
                    .Single(s => s.SueldoId == sueldo.SueldoId)
                    ;
            /*
            var f = db.Facturas
                .Select(fac => new
                {
                    Importe = fac.Importe
                })
                .Where(fac => fac.Importe );

            var listaEmpleados = db.Empleados
                .Select(empleados => new
                {
                    EmpleadoId = empleados.EmpleadoId,
                    Nombres = empleados.Nombres + " " + empleados.Apellidos,
                }).ToList();
            */
            var f1 = sueldo.SueldoBase;

            var facturas = db.Facturas.FirstOrDefault();
            var cargoS = db.Cargos.FirstOrDefault();

            CalculoSueldos calcSueldos = new CalculoSueldos(c, f);
            var sueldoF = calcSueldos.Sueldo(s);
            if (calcSueldos.Aprobado(f))
            {
                sueldoF = sueldoF + 100;

            }

            ViewBag.CalcSueldos = sueldoF;
             
            return View(sueldo);
        }
        
            /*
            public IActionResult Detalles(int id)
            {
                var empleado = db.Empleados
                    .Include(empleado => empleado.Sucursal)
                    .Include(empleado => empleado.Departamento)
                    .Include(empleado => empleado.DesempenoEm)
                    .Include(empleado => empleado.DesempenoSc)
                    .Include(empleado => empleado.Sueldo)
                        .ThenInclude(sueldo => sueldo.Facturas)
                    .Include(empleado => empleado.Sueldo)
                        .ThenInclude(sueldo => sueldo.Cargos)
                    .Single(empleado => empleado.EmpleadoId == id)
                    ;


                return View(empleado);
            }
            */
        }
}
