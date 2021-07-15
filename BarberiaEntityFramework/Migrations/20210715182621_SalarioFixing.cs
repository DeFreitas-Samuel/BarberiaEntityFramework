using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberiaEntityFramework.Migrations
{
    public partial class SalarioFixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Salario",
                table: "Empleado",
                type: "decimal(7,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Empleado");
        }
    }
}
