using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mini_Core_FiltroFechas.Migrations
{
    /// <inheritdoc />
    public partial class Deploy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    departamentoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departamentoNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departam__A67AC158FF24ADC8", x => x.departamentoID);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    empleadoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empleadoNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Empleado__CCDD5018E90D62A7", x => x.empleadoID);
                });

            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    gastoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gastoFecha = table.Column<DateOnly>(type: "date", nullable: false),
                    gastoDescripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    gastoMonto = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    gastoEmpleadoID = table.Column<int>(type: "int", nullable: true),
                    gastoDepartamentoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Gasto__3D97892584106D8D", x => x.gastoID);
                    table.ForeignKey(
                        name: "FK__Gasto__gastoDepa__4E88ABD4",
                        column: x => x.gastoDepartamentoID,
                        principalTable: "Departamento",
                        principalColumn: "departamentoID");
                    table.ForeignKey(
                        name: "FK__Gasto__gastoEmpl__4D94879B",
                        column: x => x.gastoEmpleadoID,
                        principalTable: "Empleado",
                        principalColumn: "empleadoID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_gastoDepartamentoID",
                table: "Gasto",
                column: "gastoDepartamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_gastoEmpleadoID",
                table: "Gasto",
                column: "gastoEmpleadoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gasto");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
