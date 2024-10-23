using EmailPermissãoClientes.Data;
using EmailPermissãoClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailPermissãoClientes.Repositorio
{
    public class PermissaoRepositorio : IPermissaoRepositorio
    {
        public PermissaoDbContext _context;

        public PermissaoRepositorio ( PermissaoDbContext context)
        {
            _context = context;
        }

        public PermissaoFormaEnvio ListarFormaPermissao(int id)
        {
            return _context.permissaoFormaEnvios.FirstOrDefault(x => x.FormaEnvioRmID == id);
        }

        public PermissaoEnviarPara ListarPermissaoEnviarPara(int id)
        {
            return _context.permissaoEnviarPara.FirstOrDefault(x => x.EnviarParaID == id);
        }

        public PermissaoTipo ListarPermissaoTipo(int id)
        {
            return _context.permissaoTipos.FirstOrDefault(x => x.TipoEmailID == id);
        }

        //public PermissaoCliente Editar(PermissaoCliente cliente)
        //{
        //    PermissaoCliente clientdbz = ListarPorId(cliente.ClientID);
        //    // nao esta puxando o cliente do banco de dados {null}
        //    clienteDB.Permitido = cliente.Permitido;
        //    clienteDB.EnviarParaID = cliente.EnviarParaID;
        //    clienteDB.FormaEnvioRmID = cliente.FormaEnvioRmID;
        //    clienteDB.TipoEmailID = cliente.TipoEmailID;

        //    _context.permissaoClientes.Update(clienteDB);
        //    _context.SaveChanges();

        //    return clienteDB;
        //}

        public PermissaoCliente ListarPorId(int id)
        {
            return _context.permissaoClientes.FirstOrDefault(x => x.ClientID == id);
        }
    }
}
