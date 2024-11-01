using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailPermissãoClientes.Migrations
{
    /// <inheritdoc />
    public partial class FKnapermissaoCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "TipoEmailID",
                table: "permissaoClientes",
                newName: "TipoEmailID1");

            migrationBuilder.RenameColumn(
                name: "FormaEnvioRmID",
                table: "permissaoClientes",
                newName: "FormaEnvioRmID1");

            migrationBuilder.RenameColumn(
                name: "EnviarParaID",
                table: "permissaoClientes",
                newName: "EnviarParaID1");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoClientes_EnviarParaID1",
                table: "permissaoClientes",
                column: "EnviarParaID1");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoClientes_FormaEnvioRmID1",
                table: "permissaoClientes",
                column: "FormaEnvioRmID1");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoClientes_TipoEmailID1",
                table: "permissaoClientes",
                column: "TipoEmailID1");

            migrationBuilder.AddForeignKey(
                name: "FK_permissaoClientes_permissaoEnviarPara_EnviarParaID1",
                table: "permissaoClientes",
                column: "EnviarParaID1",
                principalTable: "permissaoEnviarPara",
                principalColumn: "EnviarParaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_permissaoClientes_permissaoFormaEnvios_FormaEnvioRmID1",
                table: "permissaoClientes",
                column: "FormaEnvioRmID1",
                principalTable: "permissaoFormaEnvios",
                principalColumn: "FormaEnvioRmID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_permissaoClientes_permissaoTipos_TipoEmailID1",
                table: "permissaoClientes",
                column: "TipoEmailID1",
                principalTable: "permissaoTipos",
                principalColumn: "TipoEmailID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_permissaoClientes_permissaoEnviarPara_EnviarParaID1",
                table: "permissaoClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_permissaoClientes_permissaoFormaEnvios_FormaEnvioRmID1",
                table: "permissaoClientes");

            migrationBuilder.DropForeignKey(
                name: "FK_permissaoClientes_permissaoTipos_TipoEmailID1",
                table: "permissaoClientes");

            migrationBuilder.DropIndex(
                name: "IX_permissaoClientes_EnviarParaID1",
                table: "permissaoClientes");

            migrationBuilder.DropIndex(
                name: "IX_permissaoClientes_FormaEnvioRmID1",
                table: "permissaoClientes");

            migrationBuilder.DropIndex(
                name: "IX_permissaoClientes_TipoEmailID1",
                table: "permissaoClientes");

            migrationBuilder.RenameColumn(
                name: "TipoEmailID1",
                table: "permissaoClientes",
                newName: "TipoEmailID");

            migrationBuilder.RenameColumn(
                name: "FormaEnvioRmID1",
                table: "permissaoClientes",
                newName: "FormaEnvioRmID");

            migrationBuilder.RenameColumn(
                name: "EnviarParaID1",
                table: "permissaoClientes",
                newName: "EnviarParaID");

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
    }
}
