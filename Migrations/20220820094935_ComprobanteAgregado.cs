using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolloRapiApi.Migrations
{
    public partial class ComprobanteAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comprobantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedioPagoId = table.Column<int>(type: "int", nullable: true),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: true),
                    CuentasId = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comprobantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comprobantes_Cuentas_CuentasId",
                        column: x => x.CuentasId,
                        principalTable: "Cuentas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comprobantes_Enumerado_MedioPagoId",
                        column: x => x.MedioPagoId,
                        principalTable: "Enumerado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comprobantes_Enumerado_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "Enumerado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comprobantes_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_CuentasId",
                table: "Comprobantes",
                column: "CuentasId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_MedioPagoId",
                table: "Comprobantes",
                column: "MedioPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_PedidoId",
                table: "Comprobantes",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_TipoDocumentoId",
                table: "Comprobantes",
                column: "TipoDocumentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comprobantes");
        }
    }
}
