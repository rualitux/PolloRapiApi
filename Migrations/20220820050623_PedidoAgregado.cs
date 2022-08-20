using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PolloRapiApi.Migrations
{
    public partial class PedidoAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnumeradoJerarquia_Enumerado_AncestroId",
                table: "EnumeradoJerarquia");

            migrationBuilder.DropForeignKey(
                name: "FK_EnumeradoJerarquia_Enumerado_DescendienteId",
                table: "EnumeradoJerarquia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnumeradoJerarquia",
                table: "EnumeradoJerarquia");

            migrationBuilder.RenameTable(
                name: "EnumeradoJerarquia",
                newName: "EnumeradoJerarquias");

            migrationBuilder.RenameIndex(
                name: "IX_EnumeradoJerarquia_DescendienteId",
                table: "EnumeradoJerarquias",
                newName: "IX_EnumeradoJerarquias_DescendienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnumeradoJerarquias",
                table: "EnumeradoJerarquias",
                columns: new[] { "AncestroId", "DescendienteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EnumeradoJerarquias_Enumerado_AncestroId",
                table: "EnumeradoJerarquias",
                column: "AncestroId",
                principalTable: "Enumerado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EnumeradoJerarquias_Enumerado_DescendienteId",
                table: "EnumeradoJerarquias",
                column: "DescendienteId",
                principalTable: "Enumerado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnumeradoJerarquias_Enumerado_AncestroId",
                table: "EnumeradoJerarquias");

            migrationBuilder.DropForeignKey(
                name: "FK_EnumeradoJerarquias_Enumerado_DescendienteId",
                table: "EnumeradoJerarquias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnumeradoJerarquias",
                table: "EnumeradoJerarquias");

            migrationBuilder.RenameTable(
                name: "EnumeradoJerarquias",
                newName: "EnumeradoJerarquia");

            migrationBuilder.RenameIndex(
                name: "IX_EnumeradoJerarquias_DescendienteId",
                table: "EnumeradoJerarquia",
                newName: "IX_EnumeradoJerarquia_DescendienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnumeradoJerarquia",
                table: "EnumeradoJerarquia",
                columns: new[] { "AncestroId", "DescendienteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EnumeradoJerarquia_Enumerado_AncestroId",
                table: "EnumeradoJerarquia",
                column: "AncestroId",
                principalTable: "Enumerado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EnumeradoJerarquia_Enumerado_DescendienteId",
                table: "EnumeradoJerarquia",
                column: "DescendienteId",
                principalTable: "Enumerado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
