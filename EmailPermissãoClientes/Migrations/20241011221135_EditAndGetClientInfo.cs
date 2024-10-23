using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailPermissãoClientes.Migrations
{
    /// <inheritdoc />
    public partial class EditAndGetClientInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnviarParID",
                table: "permissaoClientes",
                newName: "EnviarParaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnviarParaID",
                table: "permissaoClientes",
                newName: "EnviarParID");
        }
    }
}
