using Microsoft.EntityFrameworkCore;
using Modelo.Operaciones;
using System;
using System.Linq;
using Xunit;

namespace TestEvaluacion
{
    public class TestFacturas
    {
        [Theory]
        [InlineData(1, 10000f)]
        [InlineData(2, 10000f)]        
        [InlineData(4, 10000f)]
        [InlineData(5, 10000f)]
        [InlineData(6, 10000f)]
        [InlineData(7, 10000f)]
        [InlineData(8, 10000f)]
        [InlineData(9, 10000f)]
        [InlineData(10, 10000f)]
        [InlineData(11, 10000f)]
        [InlineData(12, 10000f)]
        [InlineData(13, 10000f)]
        [InlineData(14, 10000f)]
        [InlineData(15, 10000f)]
        [InlineData(16, 10000f)]
        [InlineData(17, 10000f)]
        [InlineData(18, 10000f)]        
        [InlineData(20, 10000f)]
        [InlineData(21, 10000f)]
        [InlineData(22, 10000f)]
        [InlineData(23, 10000f)]
        [InlineData(24, 10000f)]
        [InlineData(25, 10000f)]
        public void TestCalBono(int id,float esperado)
        {
            var db = DBBuilder.GetDB();

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

            CalculoSueldos calcSueldos = new CalculoSueldos(c, f);
            var sueldoF = calcSueldos.Sueldo(s);
            var sBonos = 0f;
            bool sl=false;
            if (calcSueldos.Aprobado(f))
            {
                sueldoF = sueldoF + 100;
                sBonos = sueldoF + 100;
                sl = true;

            }
            else
            {
                sBonos = sueldoF;
            }
            var sin = calcSueldos.totIVA(s);
            Decimal sf = Math.Round((decimal)sBonos, 3);
            string mensaje = $"Empleado {e.Nombres +" "+ e.Apellidos}, esperado {esperado} distinto {sin}";

            Assert.True(sin > esperado, mensaje);
            
        }

        [Theory]        
        [InlineData(4, 486.4782f)]
        [InlineData(5, 492.933f)]
        [InlineData(6, 481.204f)]
        [InlineData(7, 567.139f)]
        [InlineData(8, 477.852f)]
        [InlineData(9, 489.990f)]
        [InlineData(10, 670.009f)]
        [InlineData(11, 477.817f)]
        [InlineData(12, 559.290f)]
        [InlineData(13, 710.979f)]
        [InlineData(14, 489.156f)]
        [InlineData(15, 702.048f)]
        [InlineData(16, 488.267f)]
        [InlineData(17, 490.007f)]
        [InlineData(18, 486.879f)]        
        [InlineData(20, 510.005f)]
        [InlineData(21, 489.982f)]
        [InlineData(22, 734.793f)]
        [InlineData(23, 485.630f)]
        [InlineData(24, 670.261f)]
        [InlineData(25, 490.009f)]
        public void TestCalSueldo(int id, float esperado)
        {
            var db = DBBuilder.GetDB();

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

            CalculoSueldos calcSueldos = new CalculoSueldos(c, f);
            var sueldoF = calcSueldos.Sueldo(s);
            var sBonos = 0f;
            bool sl = false;
            if (calcSueldos.Aprobado(f))
            {
                sueldoF = sueldoF + 100;
                sBonos = sueldoF + 100;
                sl = true;

            }
            else
            {
                sBonos = sueldoF;
            }

            Decimal sf = Math.Round((decimal)sBonos, 2);
            Decimal desperado = Math.Round((decimal)esperado, 2);
            string mensaje = $"Empleado {e.Nombres + " " + e.Apellidos}, esperado {esperado} distinto {sf}";

            Assert.True(sf > desperado, mensaje);
            
        }

    }
}
