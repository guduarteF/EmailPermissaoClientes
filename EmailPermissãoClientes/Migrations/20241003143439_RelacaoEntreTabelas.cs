using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailPermissãoClientes.Migrations
{
    /// <inheritdoc />
    public partial class RelacaoEntreTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "permissaoClientesClientID",
                table: "permissaoTipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "permissaoClientesClientID",
                table: "permissaoFormaEnvios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "permissaoClientesClientID",
                table: "permissaoEnviarPara",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_permissaoTipos_permissaoClientesClientID",
                table: "permissaoTipos",
                column: "permissaoClientesClientID");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoFormaEnvios_permissaoClientesClientID",
                table: "permissaoFormaEnvios",
                column: "permissaoClientesClientID");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoEnviarPara_permissaoClientesClientID",
                table: "permissaoEnviarPara",
                column: "permissaoClientesClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_permissaoEnviarPara_permissaoClientes_permissaoClientesClientID",
                table: "permissaoEnviarPara",
                column: "permissaoClientesClientID",
                principalTable: "permissaoClientes",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_permissaoFormaEnvios_permissaoClientes_permissaoClientesClientID",
                table: "permissaoFormaEnvios",
                column: "permissaoClientesClientID",
                principalTable: "permissaoClientes",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_permissaoTipos_permissaoClientes_permissaoClientesClientID",
                table: "permissaoTipos",
                column: "permissaoClientesClientID",
                principalTable: "permissaoClientes",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_permissaoEnviarPara_permissaoClientes_permissaoClientesClientID",
                table: "permissaoEnviarPara");

            migrationBuilder.DropForeignKey(
                name: "FK_permissaoFormaEnvios_permissaoClientes_permissaoClientesClientID",
                table: "permissaoFormaEnvios");

            migrationBuilder.DropForeignKey(
                name: "FK_permissaoTipos_permissaoClientes_permissaoClientesClientID",
                table: "permissaoTipos");

            migrationBuilder.DropIndex(
                name: "IX_permissaoTipos_permissaoClientesClientID",
                table: "permissaoTipos");

            migrationBuilder.DropIndex(
                name: "IX_permissaoFormaEnvios_permissaoClientesClientID",
                table: "permissaoFormaEnvios");

            migrationBuilder.DropIndex(
                name: "IX_permissaoEnviarPara_permissaoClientesClientID",
                table: "permissaoEnviarPara");

            migrationBuilder.DropColumn(
                name: "permissaoClientesClientID",
                table: "permissaoTipos");

            migrationBuilder.DropColumn(
                name: "permissaoClientesClientID",
                table: "permissaoFormaEnvios");

            migrationBuilder.DropColumn(
                name: "permissaoClientesClientID",
                table: "permissaoEnviarPara");
        }
    }
}
