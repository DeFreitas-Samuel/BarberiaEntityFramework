using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberiaEntityFramework.Migrations
{
    public partial class TableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciudadID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Calle = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sucursal_Ciudad_ciudadID",
                        column: x => x.ciudadID,
                        principalTable: "Ciudad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    empleadoID = table.Column<int>(type: "int", nullable: false),
                    clienteID = table.Column<int>(type: "int", nullable: false),
                    tipoPagoID = table.Column<int>(type: "int", nullable: false),
                    sucursalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente_clienteID",
                        column: x => x.clienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Empleado_empleadoID",
                        column: x => x.empleadoID,
                        principalTable: "Empleado",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Sucursal_sucursalID",
                        column: x => x.sucursalID,
                        principalTable: "Sucursal",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_TipoPago_tipoPagoID",
                        column: x => x.tipoPagoID,
                        principalTable: "TipoPago",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacturaDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    FacturaID = table.Column<int>(type: "int", nullable: true),
                    ServicioID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturaDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FacturaDetail_Factura_FacturaID",
                        column: x => x.FacturaID,
                        principalTable: "Factura",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacturaDetail_Servicio_ServicioID",
                        column: x => x.ServicioID,
                        principalTable: "Servicio",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factura_clienteID",
                table: "Factura",
                column: "clienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_empleadoID",
                table: "Factura",
                column: "empleadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_sucursalID",
                table: "Factura",
                column: "sucursalID");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_tipoPagoID",
                table: "Factura",
                column: "tipoPagoID");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetail_FacturaID",
                table: "FacturaDetail",
                column: "FacturaID");

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetail_ServicioID",
                table: "FacturaDetail",
                column: "ServicioID");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_ciudadID",
                table: "Sucursal",
                column: "ciudadID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturaDetail");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
