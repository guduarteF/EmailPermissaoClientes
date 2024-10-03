using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailPermissãoClientes.Models
{
    public class PermissaoFormaEnvio
    {
        [Key]
        public int FormaEnvioRmID { get; set; }
        public string Descricao { get; set; }
        public PermissaoCliente permissaoClientes { get; set; }

    }
}
