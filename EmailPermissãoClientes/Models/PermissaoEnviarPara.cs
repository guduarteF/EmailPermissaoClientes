using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailPermissãoClientes.Models
{
    public class PermissaoEnviarPara
    {
        [Key]
        public int EnviarParaID { get; set; }
        public string Descrição { get; set; }
       
    }
}
