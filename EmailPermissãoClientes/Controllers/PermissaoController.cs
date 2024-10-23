using EmailPermissãoClientes.Data;
using EmailPermissãoClientes.Models;
using EmailPermissãoClientes.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace EmailPermissãoClientes.Controllers
{
    public class PermissaoController : ControllerBase
    {
        //private readonly IPermissaoRepositorio permissaoRepositorio;

        //public PermissaoController(IPermissaoRepositorio permissaoRepositorio)
        //{
        //    this.permissaoRepositorio = permissaoRepositorio;
        //}

        

        //public async Task<IActionResult> GetSingleClient(int id)
        //{
        //    var cliente = permissaoRepositorio.ListarPorId(id);
        //    return Ok(cliente);
        //}

        //[HttpPost]
        //public IActionResult UpdateClient(PermissaoCliente cliente)
        //{
        //    var v_client = permissaoRepositorio.Editar(cliente);
        //    return Ok(v_client);
        //}


        //public PermissaoDbContext p_dbContext;

        //public IActionResult Editar(int id)
        //{
        //    // TipoEmailId: [3 = Comunicação de Movimentos], [5 = Comunicação de Rebalanceamento de Carteira], [6 = Mensagem de Feliz Aniversário]
        //    // FormaEnvioRmId: [1 = Destinatário], [2 = Cópia], [3 = Cópia Oculta]
        //    // EnviarParaID: [1 = Cliente], [2 = Consultor], [3 = Ambos]
        //    p_dbContext.permissaoClientes.Add(new PermissaoCliente {Permitido = true, EnviarParaID = 2, FormaEnvioRmID = 2, TipoEmailID = 3});
        //    p_dbContext.SaveChanges();
        //    //return
               
        //}



    }    
}
