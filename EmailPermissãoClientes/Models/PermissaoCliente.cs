using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailPermissãoClientes.Models
{
    public class PermissaoCliente
    {
        [Key] 
        public int ClientID { get; set; }
        public bool Permitido { get; set; }
        public PermissaoTipo TipoEmailID { get; set; }
        public PermissaoEnviarPara EnviarParaID { get; set; }
        public PermissaoFormaEnvio FormaEnvioRmID { get; set; }
        


    }
}
