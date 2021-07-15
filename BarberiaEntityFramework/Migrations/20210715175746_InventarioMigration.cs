using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberiaEntityFramework.Migrations
{
    public partial class InventarioMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "empleadoID",
                table: "Inventario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_empleadoID",
                table: "Inventario",
                column: "empleadoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventario_Empleado_empleadoID",
                table: "Inventario",
                column: "empleadoID",
                principalTable: "Empleado",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventario_Empleado_empleadoID",
                table: "Inventario");

            migrationBuilder.DropIndex(
                name: "IX_Inventario_empleadoID",
                table: "Inventario");

            migrationBuilder.DropColumn(
                name: "empleadoID",
                table: "Inventario");
        }
    }
}
