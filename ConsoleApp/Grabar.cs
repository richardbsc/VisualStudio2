using CargarDatos;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargarDatos.DatosIniciales;

namespace ConsoleApp
{
    public class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            //Extraer del diccionario las listas
            var listaCargos = (List<Cargo>)listas[ListasTipo.Cargos];
            var listaSueldos = (List<Sueldo>)listas[ListasTipo.Sueldos];
            var listaFacturas = (List<Factura>)listas[ListasTipo.Facturas];
            var listaDesempoEm = (List<DesempenoEm>)listas[ListasTipo.DesempenoEms];
            var listaDesempoSc = (List<DesempenoSc>)listas[ListasTipo.DesempenoScs];
            var listacontrol_Asistencias = (List<Control_Asistencia>)listas[ListasTipo.Control_Asistencias];
            var listaPermisos = (List<Permiso>)listas[ListasTipo.Permisos];
            var listaSucursales = (List<Sucursal>)listas[ListasTipo.Sucursales];
            var listaBonos = (List<Bono>)listas[ListasTipo.Bonos];
            var listaDepartamento = (List<Departamento>)listas[ListasTipo.Departamentos];
            var listaEmpleados = (List<Empleado>)listas[ListasTipo.Empleados];
            var listaAumentos = (List<Aumento>)listas[ListasTipo.Aumentos];

            //si no funciona eliminar el using y db.PreparaDB();

            using (Repositorio db = EvaluacionBuilder.Crear())
            {
                db.PreparaDB();
                //Repositorio db = new Repositorio();
                db.Cargos.AddRange(listaCargos);
                db.Sueldos.AddRange(listaSueldos);
                db.Facturas.AddRange(listaFacturas);
                db.desempenoEm.AddRange(listaDesempoEm);
                db.DesempenoSc.AddRange(listaDesempoSc);
                db.Control_Asistencias.AddRange(listacontrol_Asistencias);
                db.Permisos.AddRange(listaPermisos);
                db.Sucursals.AddRange(listaSucursales);
                db.Bonos.AddRange(listaBonos);
                db.Departamentos.AddRange(listaDepartamento);
                db.Empleados.AddRange(listaEmpleados);
                db.Aumentos.AddRange(listaAumentos);


                db.SaveChanges();
            }
               

        }
    }
}
