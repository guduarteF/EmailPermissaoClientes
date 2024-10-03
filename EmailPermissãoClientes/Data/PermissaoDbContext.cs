using EmailPermissãoClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailPermissãoClientes.Data
{
    public class PermissaoDbContext : DbContext
    {

        public PermissaoDbContext(DbContextOptions<PermissaoDbContext> options) : base (options)
        {

        }

        DbSet<PermissaoCliente> permissaoClientes { get; set; }
        DbSet<PermissaoFormaEnvio> permissaoFormaEnvios { get; set; }
        DbSet<PermissaoEnviarPara> permissaoEnviarPara { get; set; }
        DbSet<PermissaoTipo> permissaoTipos { get; set; }
    }
}
