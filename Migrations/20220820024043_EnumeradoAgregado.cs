using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolloRapiApi.Migrations
{
    public partial class EnumeradoAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "ProductoPromociones",
                newName: "EnumeradoId");

            migrationBuilder.CreateTable(
                name: "Enumerado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enumerado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnumeradoJerarquia",
                columns: table => new
                {
                    AncestroId = table.Column<int>(type: "int", nullable: false),
                    DescendienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumeradoJerarquia", x => new { x.AncestroId, x.DescendienteId });
                    table.ForeignKey(
                        name: "FK_EnumeradoJerarquia_Enumerado_AncestroId",
                        column: x => x.AncestroId,
                        principalTable: "Enumerado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EnumeradoJerarquia_Enumerado_DescendienteId",
                        column: x => x.DescendienteId,
                        principalTable: "Enumerado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoPromociones_EnumeradoId",
                table: "ProductoPromociones",
                column: "EnumeradoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnumeradoJerarquia_DescendienteId",
                table: "EnumeradoJerarquia",
                column: "DescendienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoPromociones_Enumerado_EnumeradoId",
                table: "ProductoPromociones",
                column: "EnumeradoId",
                principalTable: "Enumerado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoPromociones_Enumerado_EnumeradoId",
                table: "ProductoPromociones");

            migrationBuilder.DropTable(
                name: "EnumeradoJerarquia");

            migrationBuilder.DropTable(
                name: "Enumerado");

            migrationBuilder.DropIndex(
                name: "IX_ProductoPromociones_EnumeradoId",
                table: "ProductoPromociones");

            migrationBuilder.RenameColumn(
                name: "EnumeradoId",
                table: "ProductoPromociones",
                newName: "Estado");
        }
    }
}
