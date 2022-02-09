using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloBD;
using System.Collections;
using System.Collections.Generic;

namespace WebSEP.Controllers
{    
    public class DepartamentoController : Controller
    {
        private readonly Repositorio db;
        public DepartamentoController(Repositorio db)
        {
            this.db = db;
        }
        //Recuperar la lista de materia y envia hacia la vista
        public IActionResult Index()
        {
            //Repositorio db = new Repositorio();
            IEnumerable<Departamento> listaDepartamentos = db.Departamentos;
            return View(listaDepartamentos);
        }

        //Creacion de un nuevo departamento
        //Enviar a un formulrio vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Grabar una materi 
        [HttpPost]
        public IActionResult Create( Departamento departamento)
        {
            db.Departamentos.Add(departamento);
            db.SaveChanges();

            TempData["mensaje"] = $"El departamento {departamento.Nombre} ah sido creado exitosamente";

            return RedirectToAction("Index");
        }

        //Edicion de un  departamento
        //Enviar a un formulrio con los datos del Departamento
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            return View(departamento);
        }
        //Actualizar un Departamento
        [HttpPost]
        public IActionResult Edit(Departamento departamento)
        {
            db.Departamentos.Update(departamento);
            db.SaveChanges();

            TempData["mensaje"] = $"El departamento {departamento.Nombre} ah sido actualizado exitosamente";

            return RedirectToAction("Index");
        }

        //Borrado de un  departamento
        //Enviar a un formulrio con los datos del Departamento a Eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            return View(departamento);
        }
        //Eliminar un Departamento
        [HttpPost]
        public IActionResult Delete(Departamento departamento)
        {
            db.Departamentos.Remove(departamento);
            db.SaveChanges();

            TempData["mensaje"] = $"El departamento ah sido eliminado exitosamente";

            return RedirectToAction("Index");
        }


    }
}
