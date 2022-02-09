using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{

    public class Repositorio : DbContext
    {
        public Repositorio()
        {

        }

        //public Repositorio(DbContextOptions<Repositorio> options)
        public Repositorio(DbContextOptions options)
            : base(options)
        {
        
        }

        public void PreparaDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Bono> Bonos { get; set; }
        public DbSet <Cargo> Cargos { get; set; }
        public DbSet<Control_Asistencia> Control_Asistencias { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<DesempenoSc> DesempenoSc { get; set; }
        public DbSet<DesempenoEm> desempenoEm { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Horario_Det> Horario_Dets { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Sucursal> Sucursals { get; set; }
        public DbSet<Sueldo> Sueldos { get; set; }

        public DbSet<Aumento> Aumentos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-FRUGM4F;Initial Catalog=SisEvalV4_2;Trusted_Connection=True");
            }
                
        }


        protected override void OnModelCreating(ModelBuilder model)
        {
            //Empleado
            model.Entity<Empleado>()
                .HasOne(e => e.Departamento)
                .WithMany(d => d.Empleados)
                .HasForeignKey(e => e.DepartamendoId);

            model.Entity<Empleado>()
                .HasOne(e => e.DesempenoEm)
                .WithMany(de => de.Empleados)
                .HasForeignKey(e => e.DesempenoEmId);

            model.Entity<Empleado>()
                .HasOne(e => e.DesempenoSc)
                .WithMany(ds => ds.Empleados)
                .HasForeignKey(e => e.DesempenoScId);

            model.Entity<Empleado>()
                .HasOne(e => e.Sueldo)
                .WithMany(s => s.Empleados)
                .HasForeignKey(e => e.SueldoId);

            model.Entity<Empleado>()
                .HasOne(e => e.Control_Asistencia)
                .WithMany(ca => ca.Empleados)
                .HasForeignKey(e => e.Control_AsistenciaId);
            
            //EM
            model.Entity<Empleado>()
                .HasOne(e => e.Sucursal)
                .WithMany(s => s.Empleados)
                .HasForeignKey(e => e.SucursalId);

            //Sueldo
            //Factura
            model.Entity<Factura>()
                .HasOne(f => f.Sueldo)
                .WithMany(s => s.Facturas)
                .HasForeignKey(f => f.SueldoId);              
            //Cargo
            model.Entity<Cargo>()
                .HasOne(c =>c.Sueldo)
                .WithMany(s => s.Cargos)
                .HasForeignKey(c => c.SueldoId);

            //Asistencia
            //Detalle ONEbyONE
            /*model.Entity<Control_Asistencia>()
                .HasOne(ca => ca.Horario_Det)
                .WithOne(hd => hd.Control_Asistencia)
                .HasForeignKey<Horario_Det>(hd => hd.Control_AsistenciaId);
            */


            //Permiso
            model.Entity<Permiso>()
                .HasOne(p => p.Control_Asistencia)
                .WithMany(ca => ca.Permisos)
                .HasForeignKey(p => p.Control_AsistenciaId);
            
            //Asistencia
            //Detalle ONEbyONE V2
            model.Entity<Permiso>()
                .HasOne(p => p.Horario_Det)
                .WithOne(hd => hd.Permiso)
                .HasForeignKey<Horario_Det>(hd =>hd.PermisoId);

            //Configuracion Aumento
            model.Entity<Aumento>()
                .HasKey(Aumento => new
                {
                    Aumento.EmpleadoId,
                    Aumento.BonoId
                });

            //N:N
            //Aumento
            model.Entity<Aumento>()
                .HasOne(a => a.Empleado)
                .WithMany(e => e.Aumentos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(a => a.EmpleadoId);

            model.Entity<Aumento>()
                .HasOne(a => a.Bono)
                .WithMany(b => b.Aumentos)
                .HasForeignKey(a => a.BonoId);

        }
        
    }
}
