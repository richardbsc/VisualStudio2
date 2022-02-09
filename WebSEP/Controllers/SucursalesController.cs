using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloBD;
using System.Collections.Generic;

namespace WebSEP.Controllers
{
    public class SucursalesController : Controller
    {
        private readonly Repositorio db;
        public SucursalesController(Repositorio db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Sucursal> listaSucursales = db.Sucursals;
            return View(listaSucursales);
        }

        //Creacion de un nuevo Sucursal
        //Enviar a un formulrio vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Grabar una materi 
        [HttpPost]
        public IActionResult Create(Sucursal sucursal)
        {
            db.Sucursals.Add(sucursal);
            db.SaveChanges();

            TempData["mensaje"] = $"El sucursal {sucursal.Nombre} ah sido creado exitosamente";

            return RedirectToAction("Index");
        }

        //Edicion de un  sucursal
        //Enviar a un formulrio con los datos del Sucursal
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Sucursal sucursal = db.Sucursals.Find(id);
            return View(sucursal);
        }
        //Actualizar un Sucursal
        [HttpPost]
        public IActionResult Edit(Sucursal sucursal)
        {
            db.Sucursals.Update(sucursal);
            db.SaveChanges();

            TempData["mensaje"] = $"El sucursal {sucursal.Nombre} ah sido actualizado exitosamente";

            return RedirectToAction("Index");
        }

        //Borrado de un  sucursal
        //Enviar a un formulrio con los datos del Sucursal a Eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Sucursal sucursal = db.Sucursals.Find(id);
            return View(sucursal);
        }
        //Eliminar un Sucursal
        [HttpPost]
        public IActionResult Delete(Sucursal sucursal)
        {
            db.Sucursals.Remove(sucursal);
            db.SaveChanges();

            TempData["mensaje"] = $"El sucursal ah sido eliminado exitosamente";

            return RedirectToAction("Index");
        }



    }
}
