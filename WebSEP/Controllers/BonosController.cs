using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using System.Collections.Generic;
using System.Linq;

namespace WebSEP.Controllers
{
    public class BonosController : Controller
    {
        private readonly Repositorio db;
        public BonosController(Repositorio db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Bono> listaBonos = db.Bonos
                .Include(bono => bono.Empleado);

            return View(listaBonos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var bono = db.Aumentos
                .Include(bono => bono.Empleado)
                ;

            var listaEmpleados = db.Empleados
                .Select(empleados => new
                {
                    EmpleadoId=empleados.EmpleadoId,
                    Nombres=empleados.Nombres + " "+ empleados.Apellidos,
                }).ToList();

            var selectListaEmpleados = new SelectList(listaEmpleados, "EmpleadoId", "Nombres");

            ViewBag.selectListaEmpleados = selectListaEmpleados;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Bono bono)
        {
            db.Bonos.Add(bono);
            db.SaveChanges();

            TempData["mensaje"] = $"El bono {bono.Nombre} ah sido creado exitosamente";

            return RedirectToAction("Index");
        }
    }
}
