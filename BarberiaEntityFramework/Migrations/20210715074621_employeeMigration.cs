using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberiaEntityFramework.Migrations
{
    public partial class employeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Apellido = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    NroTelefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    TipoEmpleadoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Empleado_TipoEmpleado_TipoEmpleadoID",
                        column: x => x.TipoEmpleadoID,
                        principalTable: "TipoEmpleado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_TipoEmpleadoID",
                table: "Empleado",
                column: "TipoEmpleadoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
