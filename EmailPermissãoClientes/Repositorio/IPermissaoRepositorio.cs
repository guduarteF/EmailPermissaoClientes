using EmailPermissãoClientes.Data;
using EmailPermissãoClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailPermissãoClientes.Repositorio
{
    public interface IPermissaoRepositorio
    {
        PermissaoCliente ListarPorId(int id);
        PermissaoFormaEnvio ListarFormaPermissao(int id);
        PermissaoTipo ListarPermissaoTipo(int id);
        PermissaoEnviarPara ListarPermissaoEnviarPara(int id);
        // PermissaoCliente Editar(PermissaoCliente cliente);

    }
}
