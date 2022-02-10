using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebSEP.Controllers
{
    public class SueldosController : Controller
    {
        private readonly Repositorio db;
        int iden;
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
            this.iden = id;
            var sueldo = db.Sueldos
                .Include(sueldo => sueldo.Cargos)
                .Include(sueldo => sueldo.Facturas)
                .Include(sueldo => sueldo.Empleados)
                    .ThenInclude(sueldo => sueldo.Sucursal)
                .Single(sueldo => sueldo.SueldoId == id);
                ;

            var e = db.Empleados
                .Include(em => em.Sueldo)
                .Single(em => em.SueldoId == sueldo.SueldoId)
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
          
            var f1 = sueldo.SueldoBase;

            var facturas = db.Facturas.FirstOrDefault();
            var cargoS = db.Cargos.FirstOrDefault();
            var sBonos = 0f;
            var bono = 0f;

            CalculoSueldos calcSueldos = new CalculoSueldos(c, f);
            var sueldoF = calcSueldos.Sueldo(s);
            
            if (calcSueldos.Aprobado(f))
            {
                //sueldoF = sueldoF + 100;
                sBonos = sueldoF + 100;
                bono =  100;
                TempData["mensaje"] = $"El empleado {e.Nombres +" "+ e.Apellidos}  es acreedor al Bono";

            }
            else
            {
                sBonos = sueldoF;
                TempData["mensaje"] = $"El empleado NO {e.Nombres + " " + e.Apellidos}  es acreedor al Bono";
            }

            decimal decSuelF = Math.Round((decimal)sueldoF, 2);
            decimal decBonos = Math.Round((decimal)sBonos, 2);

            ViewBag.CalcSueldos = decSuelF;
            ViewBag.Bono = bono;
            ViewBag.CalcSueldosB = decBonos;
            return View(sueldo);
        }

        [HttpPost]
        public IActionResult Detalles(Sueldo  sueldo)
        {
            return RedirectToAction("Index");
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
