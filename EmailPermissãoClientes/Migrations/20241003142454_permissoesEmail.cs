using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmailPermissãoClientes.Migrations
{
    /// <inheritdoc />
    public partial class permissoesEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "permissaoClientes",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Permitido = table.Column<bool>(type: "bit", nullable: false),
                    TipoEmailID = table.Column<int>(type: "int", nullable: false),
                    EnviarParID = table.Column<int>(type: "int", nullable: false),
                    FormaEnvioRmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoClientes", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "permissaoEnviarPara",
                columns: table => new
                {
                    EnviarParaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoEnviarPara", x => x.EnviarParaID);
                });

            migrationBuilder.CreateTable(
                name: "permissaoFormaEnvios",
                columns: table => new
                {
                    FormaEnvioRmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoFormaEnvios", x => x.FormaEnvioRmID);
                });

            migrationBuilder.CreateTable(
                name: "permissaoTipos",
                columns: table => new
                {
                    TipoEmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoTipos", x => x.TipoEmailID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permissaoClientes");

            migrationBuilder.DropTable(
                name: "permissaoEnviarPara");

            migrationBuilder.DropTable(
                name: "permissaoFormaEnvios");

            migrationBuilder.DropTable(
                name: "permissaoTipos");
        }
    }
}
