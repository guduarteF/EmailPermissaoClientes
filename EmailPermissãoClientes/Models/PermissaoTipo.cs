using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailPermissãoClientes.Models
{
    public class PermissaoTipo
    {
        [Key]
        public int TipoEmailID { get; set; }

        public string Descrição { get; set;}
        
    }
}
