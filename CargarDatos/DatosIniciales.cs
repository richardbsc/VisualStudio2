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

            Sueldo s3 = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sdman = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sjher = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sstac = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sfs = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sdsim = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo spguz = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo scfer = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo smcar = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo srsm = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sjcar = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sjcarrillo = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sbmej = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sjestu = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo svalt = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo smsara = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sjval = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sftoap = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sksant = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sazap = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo somen = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sdgue = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            Sueldo sgf = new Sueldo()
            {
                SueldoBase = 420.00f

            };

            List<Sueldo> listaSueldos = new List<Sueldo>()
            { 
                s1,s2,s3,sdman, sjher, sstac, sfs, sdsim, spguz, scfer, smcar, srsm, sjcar, sjcarrillo, sbmej, 
                sjestu,svalt,smsara,sjval, sftoap,sksant,sazap, somen,sdgue,sgf
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

            Cargo Vendedor3 = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = s3
            };
            Cargo vsdman = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sdman
            };
            Cargo vsjher = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sjher
            };
            Cargo vsstac = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sstac
            };
            Cargo vsfs = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sfs
            };
            Cargo vsdsim = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sdsim
            };
            Cargo vspguz = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = spguz
            };
            Cargo vscfer = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = scfer
            };
            Cargo vsmcar = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = smcar
            };
            Cargo vsrsm = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = srsm
            };
            Cargo vsjcar = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sjcar
            };
            Cargo vsjcarrillo = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sjcarrillo
            };
            Cargo vsbmej = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sbmej
            };
            Cargo vsjestu = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sjestu
            };
            Cargo vsvalt = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = svalt
            };
            Cargo vsmsara = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = smsara
            };
            Cargo vsjval = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sjval
            };
            Cargo vsftoap = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sftoap
            };
            Cargo vsksant = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sksant
            };
            Cargo vsazap = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sazap
            };
            Cargo vsomen = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = somen
            };
            Cargo vsdgue = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sdgue
            };
            Cargo vsgf = new Cargo()
            {
                Nombre = "Vendedor",
                Salario = 50.00f,
                Sueldo = sgf
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
                Vendedor, Tecnico,Vendedor3,vsdman, vsjher, vsstac, vsfs, vsdsim, vspguz, vscfer, vsmcar, vsrsm, vsjcar, vsjcarrillo, vsbmej,
                vsjestu,vsvalt,vsmsara,vsjval, vsftoap,vsksant,vsazap, vsomen,vsdgue,vsgf
            };
            #endregion

            //FACTURAS
            #region
            Factura f1 = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 10580.45f,
                Sueldo = s1
            };

            Factura f2 = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 9785.45f,
                Sueldo = s2
            };

            Factura f3 = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 15789.46f,
                Sueldo = s3
            };

            Factura fsdman = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 1845.56f,
                Sueldo = sdman
            };
            Factura fsjher = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 2568.45f,
                Sueldo = sjher
            };
            Factura fsstac = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 1254.89f,
                Sueldo = sstac
            };
            Factura fsfs = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 10879.55f,
                Sueldo = sfs
            };
            Factura fsdsim = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 879.42f,
                Sueldo = sdsim
            };
            Factura fspguz = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 2238.88f,
                Sueldo = spguz
            };
            Factura fscfer = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 11201f,
                Sueldo = scfer
            };
            Factura fsmcar = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 875.45f,
                Sueldo = smcar
            };
            Factura fsrsm = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 10000.45f,
                Sueldo = srsm
            };
            Factura fsjcar = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 15789.62f,
                Sueldo = sjcar
            };
            Factura fsjcarrillo = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 2145.50f,
                Sueldo = sjcarrillo
            };
            Factura fsbmej = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 14789.43f,
                Sueldo = sbmej
            };
            Factura fsjestu = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 2045.87f,
                Sueldo = sjestu
            };
            Factura fsvalt = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 2240.78f,
                Sueldo = svalt
            };
            Factura fsmsara = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 1890.45f,
                Sueldo = smsara
            };
            Factura fsjval = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 546.78f,
                Sueldo = sjval
            };
            Factura fsftoap = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 4480.55f,
                Sueldo = sftoap
            };
            Factura fsksant = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 2237.95f,
                Sueldo = sksant
            };
            Factura fsazap = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 18456.78f,
                Sueldo = sazap
            };
            Factura fsomen = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 1750.56f,
                Sueldo = somen
            };
            Factura fsdgue = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 11229.21f,
                Sueldo = sdgue
            };
            Factura fsgf = new Factura()
            {
                Fecha = new DateTime(2021, 8, 30),
                Importe = 2240.98f,
                Sueldo = sgf
            };

            List<Factura> listaFacturas = new List<Factura>()
            {
                f1,f2,f3,fsdman, fsjher, fsstac, fsfs, fsdsim, fspguz, fscfer, fsmcar, fsrsm, fsjcar, fsjcarrillo, fsbmej,
                fsjestu,fsvalt,fsmsara,fsjval, fsftoap,fsksant,fsazap, fsomen,fsdgue,fsgf
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

            Control_Asistencia caEstefania = new Control_Asistencia()
            {
                Ingreso = new DateTime(2022,2,18,8,05,0),
                SalidaAlmuerzo = new DateTime(2022, 2, 18, 13, 00, 0),
                EntradaAlmuerzo = new DateTime(2022, 2, 18,14, 05, 0),
                Salida = new DateTime(2022, 2, 18, 18, 31, 0)
            };

            Control_Asistencia casdman = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casjher = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casstac = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casfs = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casdsim = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia caspguz = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia cascfer = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casmcar = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casrsm = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casjcar = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casjcarrillo = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casbmej = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casjestu = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casvalt = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casmsara = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casjval = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casftoap = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casksant = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casazap = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casomen = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casdgue = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };
            Control_Asistencia casgf = new Control_Asistencia()
            {
                Ingreso = DateTime.Now,
                SalidaAlmuerzo = DateTime.Now,
                EntradaAlmuerzo = DateTime.Now,
                Salida = DateTime.Now
            };

            List<Control_Asistencia> listacontrol_Asistencias = new List<Control_Asistencia>()
            {
                ca1, caJose,caEstefania, casdman, casjher, casstac, casfs, casdsim, caspguz, cascfer, casmcar, casrsm, casjcar, casjcarrillo, casbmej,
                casjestu,casvalt,casmsara,casjval, casftoap,casksant,casazap, casomen,casdgue,casgf
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
                Control_Asistencia = caJose,
                Sueldo = s2,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Norte
            };

            Empleado Estefania = new Empleado()
            {
                Nombres = "Estefania",
                Apellidos = "Ortiz",
                Cedula = 1234567892,
                Direccion = "Av. Teniente Hugo Ortiz S-45",
                Telefono = 023123458,
                Email = "eo@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = caEstefania,
                Sueldo = s3,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Sur
            };

            Empleado DianaM = new Empleado()
            {
                Nombres = "Diana",
                Apellidos = "Mantilla",
                Cedula = 1234567893,
                Direccion = "Quito Sur",
                Telefono = 023123459,
                Email = "dman@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casdman,
                Sueldo = sdman,
                DesempenoEm = deM,
                DesempenoSc = dsB,
                Sucursal = Sur
            };
            Empleado JorgeH = new Empleado()
            {
                Nombres = "Jorge",
                Apellidos = "Herrera",
                Cedula = 1234567894,
                Direccion = "Av. Napo S/N 456",
                Telefono = 023123410,
                Email = "jherr@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casjher,
                Sueldo = sjher,
                DesempenoEm = deB,
                DesempenoSc = dsM,
                Sucursal = Norte
            };
            Empleado StalinCa = new Empleado()
            {
                Nombres = "Stalin",
                Apellidos = "Cataluna",
                Cedula = 1234567895,
                Direccion = "Villaflora y Tente. Hugo Ortiz",
                Telefono = 023123411,
                Email = "scat@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casstac,
                Sueldo = sstac,
                DesempenoEm = deM,
                DesempenoSc = dsM,
                Sucursal = Sur
            };
            Empleado FreddySan = new Empleado()
            {
                Nombres = "Freddy",
                Apellidos = "Sandoval",
                Cedula = 1234567896,
                Direccion = "Shiris Y Suecia",
                Telefono = 023123412,
                Email = "fsand@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casfs,
                Sueldo = sfs,
                DesempenoEm = deE,
                DesempenoSc = dsM,
                Sucursal = Centro
            };
            Empleado DennisSim = new Empleado()
            {
                Nombres = "Dennis",
                Apellidos = "Simbana",
                Cedula = 1234567897,
                Direccion = "La Carolina N-125",
                Telefono = 023123413,
                Email = "dsim@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casdsim,
                Sueldo = sdsim,
                DesempenoEm = deM,
                DesempenoSc = dsE,
                Sucursal = Valle
            };
            Empleado PaulGu = new Empleado()
            {
                Nombres = "Paul",
                Apellidos = "Guzman",
                Cedula = 1234567898,
                Direccion = "Diego de Almagro Oe-7",
                Telefono = 023123414,
                Email = "eo@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = caspguz,
                Sueldo = spguz,
                DesempenoEm = deM,
                DesempenoSc = dsM,
                Sucursal = Centro
            };
            Empleado CatalinaFer = new Empleado()
            {
                Nombres = "Catalina",
                Apellidos = "Fernandez",
                Cedula = 1234567899,
                Direccion = "La Marin",
                Telefono = 023123415,
                Email = "cfer@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = cascfer,
                Sueldo = scfer,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Norte
            };
            Empleado MarioCarr = new Empleado()
            {
                Nombres = "Mario",
                Apellidos = "Carrion",
                Cedula = 1234567811,
                Direccion = "Av. Naciones Unidas Y Amazonas",
                Telefono = 023123416,
                Email = "mcarr@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casmcar,
                Sueldo = smcar,
                DesempenoEm = deM,
                DesempenoSc = dsE,
                Sucursal = Sur
            };
            Empleado RicardoSm = new Empleado()
            {
                Nombres = "Ricardo",
                Apellidos = "Smit",
                Cedula = 1234567812,
                Direccion = "De los Pinos, El inca",
                Telefono = 023123417,
                Email = "rsmi@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casrsm,
                Sueldo = srsm,
                DesempenoEm = deE,
                DesempenoSc = dsM,
                Sucursal = Centro
            };
            Empleado JulioCar = new Empleado()
            {
                Nombres = "Julio",
                Apellidos = "Carcelen",
                Cedula = 1234567813,
                Direccion = "Av. El Inca",
                Telefono = 023123418,
                Email = "jcar@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casjcar,
                Sueldo = sjcar,
                DesempenoEm = deE,
                DesempenoSc = dsE,
                Sucursal = Sur
            };
            Empleado JhonatanCar = new Empleado()
            {
                Nombres = "Jhonatan",
                Apellidos = "Carrillo",
                Cedula = 1234567814,
                Direccion = "Av. Amazona y Colon",
                Telefono = 023123419,
                Email = "jcarr@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casjcarrillo,
                Sueldo = sjcarrillo,
                DesempenoEm = deM,
                DesempenoSc = dsB,
                Sucursal = Valle
            };
            Empleado ByronMej = new Empleado()
            {
                Nombres = "Byron",
                Apellidos = "Mejia",
                Cedula = 1234567815,
                Direccion = "Isla Floreana N78-5",
                Telefono = 023123420,
                Email = "bmej@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casbmej,
                Sueldo = sbmej,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Sur
            };
            Empleado JhonEst = new Empleado()
            {
                Nombres = "Jhon",
                Apellidos = "Estupinan",
                Cedula = 1234567816,
                Direccion = "Av. 6 de Diciembre y El Inca",
                Telefono = 023123421,
                Email = "jest@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casjestu,
                Sueldo = sjestu,
                DesempenoEm = deM,
                DesempenoSc = dsM,
                Sucursal = Centro
            };
            Empleado ValeriaAl = new Empleado()
            {
                Nombres = "Valeria",
                Apellidos = "Altamirano",
                Cedula = 1234567817,
                Direccion = "Av. Del Maestro N-16",
                Telefono = 023123422,
                Email = "valta@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casvalt,
                Sueldo = svalt,
                DesempenoEm = deB,
                DesempenoSc = dsB,
                Sucursal = Norte
            };
            Empleado MishelSa = new Empleado()
            {
                Nombres = "Mishelle",
                Apellidos = "Sarango",
                Cedula = 1234567818,
                Direccion = "La mexico y Bobonaza",
                Telefono = 023123423,
                Email = "msar@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casmsara,
                Sueldo = smsara,
                DesempenoEm = deM,
                DesempenoSc = dsB,
                Sucursal = Valle
            };
            Empleado JairoVa = new Empleado()
            {
                Nombres = "Jairo",
                Apellidos = "Valverde",
                Cedula = 1234567819,
                Direccion = "CC Recreo ",
                Telefono = 023123424,
                Email = "jval@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = caEstefania,
                Sueldo = s3,
                DesempenoEm = deM,
                DesempenoSc = dsE,
                Sucursal = Sur
            };
            Empleado FreddyTo = new Empleado()
            {
                Nombres = "Freddy",
                Apellidos = "Toapanta",
                Cedula = 1234567821,
                Direccion = "Chillogallo",
                Telefono = 023123425,
                Email = "ftoa@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casftoap,
                Sueldo = sftoap,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Norte
            };
            Empleado KatySan = new Empleado()
            {
                Nombres = "Katy",
                Apellidos = "Santillan",
                Cedula = 1234567822,
                Direccion = "Quitumbe",
                Telefono = 023123426,
                Email = "ksan@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casksant,
                Sueldo = sksant,
                DesempenoEm = deM,
                DesempenoSc = dsB,
                Sucursal = Valle
            };
            Empleado AndreaZ = new Empleado()
            {
                Nombres = "Andrea",
                Apellidos = "Zapata",
                Cedula = 1234567823,
                Direccion = "Carapungo ",
                Telefono = 023123427,
                Email = "azant@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casazap,
                Sueldo = sazap,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Norte
            };
            Empleado OscarM = new Empleado()
            {
                Nombres = "Oscar",
                Apellidos = "Meneses",
                Cedula = 1234567824,
                Direccion = "La Bota",
                Telefono = 023123428,
                Email = "omen@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casomen,
                Sueldo = somen,
                DesempenoEm = deM,
                DesempenoSc = dsE,
                Sucursal = Sur
            };
            Empleado DanielaG = new Empleado()
            {
                Nombres = "Daniela",
                Apellidos = "Guerrero",
                Cedula = 1234567825,
                Direccion = "El triangulo",
                Telefono = 023123429,
                Email = "dgue@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casdgue,
                Sueldo = sdgue,
                DesempenoEm = deE,
                DesempenoSc = dsB,
                Sucursal = Valle
            };
            Empleado GabyF = new Empleado()
            {
                Nombres = "Gaby",
                Apellidos = "Farinango",
                Cedula = 1234567826,
                Direccion = "Sangolqui",
                Telefono = 023123430,
                Email = "gfar@gmail.com",
                Departamento = Ventas,
                Control_Asistencia = casgf,
                Sueldo = sgf,
                DesempenoEm = deB,
                DesempenoSc = dsB,
                Sucursal = Valle
            };


            List<Empleado> listaEmpleados = new List<Empleado>()
            {
                Andres, Jose,Estefania, DianaM,JorgeH,StalinCa,FreddySan,DennisSim,PaulGu,CatalinaFer,MarioCarr,RicardoSm,JulioCar,
                JhonatanCar,ByronMej,JhonEst,ValeriaAl,MishelSa,JairoVa,FreddyTo,KatySan,AndreaZ,OscarM,DanielaG,GabyF
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
