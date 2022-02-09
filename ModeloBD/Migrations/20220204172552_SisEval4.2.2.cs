using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloBD.Migrations
{
    public partial class SisEval422 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Control_Asistencias",
                columns: table => new
                {
                    Control_AsistenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ingreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalidaAlmuerzo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntradaAlmuerzo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Control_Asistencias", x => x.Control_AsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "desempenoEm",
                columns: table => new
                {
                    DesempenoEmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_desempenoEm", x => x.DesempenoEmId);
                });

            migrationBuilder.CreateTable(
                name: "DesempenoSc",
                columns: table => new
                {
                    DesempenoScId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesempenoSc", x => x.DesempenoScId);
                });

            migrationBuilder.CreateTable(
                name: "Sucursals",
                columns: table => new
                {
                    SucursalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursals", x => x.SucursalId);
                });

            migrationBuilder.CreateTable(
                name: "Sueldos",
                columns: table => new
                {
                    SueldoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SueldoBase = table.Column<float>(type: "real", nullable: false),
                    FacturasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sueldos", x => x.SueldoId);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horario_DetId = table.Column<int>(type: "int", nullable: false),
                    Control_AsistenciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisoId);
                    table.ForeignKey(
                        name: "FK_Permisos_Control_Asistencias_Control_AsistenciaId",
                        column: x => x.Control_AsistenciaId,
                        principalTable: "Control_Asistencias",
                        principalColumn: "Control_AsistenciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    SueldoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CargoId);
                    table.ForeignKey(
                        name: "FK_Cargos_Sueldos_SueldoId",
                        column: x => x.SueldoId,
                        principalTable: "Sueldos",
                        principalColumn: "SueldoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamendoId = table.Column<int>(type: "int", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    Control_AsistenciaId = table.Column<int>(type: "int", nullable: false),
                    SueldoId = table.Column<int>(type: "int", nullable: false),
                    DesempenoEmId = table.Column<int>(type: "int", nullable: false),
                    DesempenoScId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                    table.ForeignKey(
                        name: "FK_Empleados_Control_Asistencias_Control_AsistenciaId",
                        column: x => x.Control_AsistenciaId,
                        principalTable: "Control_Asistencias",
                        principalColumn: "Control_AsistenciaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Departamentos_DepartamendoId",
                        column: x => x.DepartamendoId,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_desempenoEm_DesempenoEmId",
                        column: x => x.DesempenoEmId,
                        principalTable: "desempenoEm",
                        principalColumn: "DesempenoEmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_DesempenoSc_DesempenoScId",
                        column: x => x.DesempenoScId,
                        principalTable: "DesempenoSc",
                        principalColumn: "DesempenoScId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Sucursals_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursals",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Sueldos_SueldoId",
                        column: x => x.SueldoId,
                        principalTable: "Sueldos",
                        principalColumn: "SueldoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Importe = table.Column<float>(type: "real", nullable: false),
                    SueldoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                    table.ForeignKey(
                        name: "FK_Facturas_Sueldos_SueldoId",
                        column: x => x.SueldoId,
                        principalTable: "Sueldos",
                        principalColumn: "SueldoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horario_Dets",
                columns: table => new
                {
                    Horario_DetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario_Dets", x => x.Horario_DetId);
                    table.ForeignKey(
                        name: "FK_Horario_Dets_Permisos_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permisos",
                        principalColumn: "PermisoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bonos",
                columns: table => new
                {
                    BonoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonos", x => x.BonoId);
                    table.ForeignKey(
                        name: "FK_Bonos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aumentos",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    BonoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aumentos", x => new { x.EmpleadoId, x.BonoId });
                    table.ForeignKey(
                        name: "FK_Aumentos_Bonos_BonoId",
                        column: x => x.BonoId,
                        principalTable: "Bonos",
                        principalColumn: "BonoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aumentos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aumentos_BonoId",
                table: "Aumentos",
                column: "BonoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bonos_EmpleadoId",
                table: "Bonos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_SueldoId",
                table: "Cargos",
                column: "SueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Control_AsistenciaId",
                table: "Empleados",
                column: "Control_AsistenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamendoId",
                table: "Empleados",
                column: "DepartamendoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DesempenoEmId",
                table: "Empleados",
                column: "DesempenoEmId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DesempenoScId",
                table: "Empleados",
                column: "DesempenoScId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SucursalId",
                table: "Empleados",
                column: "SucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SueldoId",
                table: "Empleados",
                column: "SueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_SueldoId",
                table: "Facturas",
                column: "SueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_Dets_PermisoId",
                table: "Horario_Dets",
                column: "PermisoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_Control_AsistenciaId",
                table: "Permisos",
                column: "Control_AsistenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aumentos");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Horario_Dets");

            migrationBuilder.DropTable(
                name: "Bonos");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Control_Asistencias");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "desempenoEm");

            migrationBuilder.DropTable(
                name: "DesempenoSc");

            migrationBuilder.DropTable(
                name: "Sucursals");

            migrationBuilder.DropTable(
                name: "Sueldos");
        }
    }
}
