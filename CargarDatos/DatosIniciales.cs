using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo 
        {
        Aumentos, Bonos, Cargos, Control_Asistencias,
        Departamentos, DesempenoEms, DesempenoScs,
        Empleados,Facturas,Horario_Dets,Permisos,
        Sucursales,Sueldos
        }

        public Dictionary<ListasTipo, object> Carga()
        {

            //Lista de Departamentos
            #region            
            Departamento Contabilidad = new Departamento()
            {
                Nombre = "Contabilidad"
            };
            Departamento Ventas = new Departamento()
            {
                Nombre = "Ventas"
            };
            Departamento Bodega = new Departamento()
            {
                Nombre = "Bodega"
            };
            Departamento Sistemas = new Departamento()
            {
                Nombre = "Sistemas"
            };
            Departamento Gerencia = new Departamento()
            {
                Nombre = "Gerencia"
            };
            Departamento RRHH = new Departamento()
            {
                Nombre = "RRHH"
            };

            List<Departamento> listaDepartamentos = new List<Departamento>()
            {
                Contabilidad,Ventas,Bodega,Sistemas,Gerencia,RRHH
            };            
            #endregion

            //SUELDOS
            #region
            Sueldo s1 = new Sueldo()
            {
                SueldoBase = 420.00f
                
            };

            Sueldo s2 = new Sueldo()
            {
                SueldoBase = 470.00f

            };
            List<Sueldo> listaSueldos = new List<Sueldo>()
            { 
                s1,s2
            };

            #endregion

            //Cargo
            //VINCULADO CON CARGO - SUELDO OJO 
            #region
            Cargo Vendedor = new Cargo()
            {
                Nombre="Vendedor",
                Salario = 50.00f,
                Sueldo = s1
            };

            Cargo Tecnico = new Cargo()
            {
                Nombre = "Tecnico",
                Salario = 70.00f,
                Sueldo = s2
            };
            

            Cargo Contador = new Cargo()
            {
                Nombre = "Contador",
                Salario = 60.00f,
                Sueldo = s1
            };
           
            Cargo Bodeguero = new Cargo()
            {
                Nombre = "Bodeguero",
                Salario = 40.00f,
                Sueldo = s1
            };
            
            List<Cargo> listaCargos = new List<Cargo>()
            {
                Vendedor, Tecnico
            };
            #endregion

            //FACTURAS
            #region
            Factura f1 = new Factura()
            {
                Fecha = DateTime.Now,
                Importe = 420.00f,
                Sueldo = s1
            };

            Factura f2 = new Factura()
            {
                Fecha = DateTime.Now,
                Importe = 570.00f,
                Sueldo = s2
            };

            List<Factura> listaFacturas = new List<Factura>()
            {
                f1,f2
            };
            #endregion

            //---------
            //DESEMP EMPLEADOS
            //---------
            #region
            DesempenoEm deM = new DesempenoEm()
            {
                Nombre = "Malo",
                Calificacion = "ML"
            };
            DesempenoEm deB = new DesempenoEm()
            {
                Nombre = "Bueno",
                Calificacion = "BN"
            };
            DesempenoEm deE = new DesempenoEm()
            {
                Nombre = "Excelente",
                Calificacion = "EX"
            };

            List<DesempenoEm> listaDesEmp = new List<DesempenoEm>()
            {
                deM, deB, deE
            };

            #endregion

            //---------
            //DESEMP SUCURSALES
            //---------
            #region
            DesempenoSc dsM = new DesempenoSc()
            {
                Nombre = "Malo",
                Calificacion = "ML"
            };
            DesempenoSc dsB = new DesempenoSc()
            {
                Nombre = "Bueno",
                Calificacion = "BN"
            };
            DesempenoSc dsE = new DesempenoSc()
            {
                Nombre = "Excelente",
                Calificacion = "EX"
            };

            List<DesempenoSc> listaDesSuc = new List<DesempenoSc>()
            {
                dsM, dsB, dsE
            };

            #endregion



            //-----------
            //CONTROL ASISTENCIA  
            //-----------
            #region
            Control_Asistencia ca1 = new Control_Asistencia()
            {
                Ingreso= DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now  
            };

            Control_Asistencia caJose = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };

            List<Control_Asistencia> listacontrol_Asistencias = new List<Control_Asistencia>()
            {
                ca1, caJose
            };
            #endregion

            //-----------
            //PERMISOS  
            //-----------
            #region
            Permiso p1 = new Permiso()
            {
                Nombre = "Enfermedad",
                Tipo = "Salud",
                Control_Asistencia = ca1
            };

            List<Permiso> listaPermisos = new List<Permiso>()
            {
                p1
            };
            #endregion

            //------------
            //HORARIO DETS
            //------------
            Horario_Det hd1 = new Horario_Det()
            {

            };

            //----------
            //SUCURSALES
            //----------
            #region
            Sucursal Sur = new Sucursal()
            {
                Nombre = "Sucursal Villaflora",
                Direccion = "Av. Villaforla OE7"
            };

            Sucursal Centro = new Sucursal()
            {
                Nombre = "Sucursal Centro",
                Direccion = "La Tola Alta"
            };
            Sucursal Norte = new Sucursal()
            {
                Nombre = "Sucursal Norte",
                Direccion = "Av. Galo Plaza y Luis Tufino"
            };
            Sucursal Valle = new Sucursal()
            {
                Nombre = "Sucursal Valle",
                Direccion = "Av. Gral. Ruminahui y Illalo"
            };

            List<Sucursal> listaSucursales = new List<Sucursal>()
            {
                Sur, Centro, Norte, Valle
            };
            #endregion

            //---------
            //EMPLEADOS
            //---------
            #region
            Empleado Andres = new Empleado()
            {
                Nombres = "Andres",
                Apellidos = "Pesantes",
                Cedula = 1234567890,
                Direccion = "Quito Tennis",
                Telefono = 023123456,
                Email = "ap@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = ca1,
                Sueldo = s1,
                DesempenoEm = deB,
                DesempenoSc = dsM,
                Sucursal = Sur
            };

            Empleado Jose = new Empleado()
            {
                Nombres = "Jose",
                Apellidos = "Pelaes",
                Cedula = 1234567891,
                Direccion = "Av. del Maestro N-125",
                Telefono = 023123457,
                Email = "jp@gmail.com",
                Departamento = Sistemas,
                Control_Asistencia = ca1,
                Sueldo = s2,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Norte
            };

            List<Empleado> listaEmpleados = new List<Empleado>()
            {
                Andres, Jose
            };
            #endregion

            

            //-----
            //BONOS
            //-----
            #region
            Bono bAndres = new Bono()
            {
                Nombre = "Bono E",
                Tipo = BonoTipo.Empleado,
                Valor = 150.00f,
                Empleado = Andres
            };

            Bono bJose = new Bono()
            {
                Nombre = "Bono s",
                Tipo = BonoTipo.Sucursal,
                Valor = 500.00f,
                Empleado = Jose
            };

            List<Bono> listaBonos = new List<Bono>()
            {
                bAndres, bJose
            };
            #endregion

            //--------
            //AUMENTOS
            //--------
            #region            
            Aumento aumentoAndres = new Aumento()
            {
                Bono = bAndres,
                Empleado = Andres
            };

            Aumento aumentoJose = new Aumento()
            {
                Bono = bJose,
                Empleado = Jose
            };

            List<Aumento> listaAumentos = new List<Aumento>()
            {
                aumentoAndres,aumentoJose
            };
            
            #endregion


            //Diccionario contiene todas las listas
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Cargos, listaCargos },
                { ListasTipo.Sueldos, listaSueldos },
                { ListasTipo.Facturas, listaFacturas },
                { ListasTipo.DesempenoEms, listaDesEmp },
                { ListasTipo.DesempenoScs, listaDesSuc },
                { ListasTipo.Control_Asistencias, listacontrol_Asistencias },
                { ListasTipo.Permisos, listaPermisos },
                { ListasTipo.Sucursales, listaSucursales },
                { ListasTipo.Bonos, listaBonos },
                { ListasTipo.Departamentos, listaDepartamentos},
                { ListasTipo.Empleados, listaEmpleados},               
                { ListasTipo.Aumentos, listaAumentos}

            };

            return dicListasDatos;
        }

     }
}
