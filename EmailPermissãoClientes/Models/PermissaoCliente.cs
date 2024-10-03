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
        public int TipoEmailID { get; set; }
        public int EnviarParID { get; set; }
        public int FormaEnvioRmID { get; set; }
        


    }
}
