using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolloRapiApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "Enumerado",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Valor = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Enumerado", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Productos",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            PrecioBruto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            PrecioNeto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            Imagen = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Productos", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Promociones",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Promociones", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "EnumeradoJerarquias",
        //        columns: table => new
        //        {
        //            AncestroId = table.Column<int>(type: "int", nullable: false),
        //            DescendienteId = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_EnumeradoJerarquias", x => new { x.AncestroId, x.DescendienteId });
        //            table.ForeignKey(
        //                name: "FK_EnumeradoJerarquias_Enumerado_AncestroId",
        //                column: x => x.AncestroId,
        //                principalTable: "Enumerado",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_EnumeradoJerarquias_Enumerado_DescendienteId",
        //                column: x => x.DescendienteId,
        //                principalTable: "Enumerado",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ProductoPromociones",
        //        columns: table => new
        //        {
        //            ProductoPromocionId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ProductoId = table.Column<int>(type: "int", nullable: false),
        //            PromocionId = table.Column<int>(type: "int", nullable: false),
        //            EnumeradoId = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ProductoPromociones", x => x.ProductoPromocionId);
        //            table.ForeignKey(
        //                name: "FK_ProductoPromociones_Enumerado_EnumeradoId",
        //                column: x => x.EnumeradoId,
        //                principalTable: "Enumerado",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ProductoPromociones_Productos_ProductoId",
        //                column: x => x.ProductoId,
        //                principalTable: "Productos",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ProductoPromociones_Promociones_PromocionId",
        //                column: x => x.PromocionId,
        //                principalTable: "Promociones",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_EnumeradoJerarquias_DescendienteId",
        //        table: "EnumeradoJerarquias",
        //        column: "DescendienteId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ProductoPromociones_EnumeradoId",
        //        table: "ProductoPromociones",
        //        column: "EnumeradoId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ProductoPromociones_ProductoId",
        //        table: "ProductoPromociones",
        //        column: "ProductoId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ProductoPromociones_PromocionId",
        //        table: "ProductoPromociones",
        //        column: "PromocionId");
        //
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnumeradoJerarquias");

            migrationBuilder.DropTable(
                name: "ProductoPromociones");

            migrationBuilder.DropTable(
                name: "Enumerado");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Promociones");
        }
    }
}
