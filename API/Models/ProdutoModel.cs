using Autoglass.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Autoglass.API.Models
{
    public class ProdutoModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }

        [Required]
        public int Situacao { get; set; }

        [Required]
        public System.DateTime DataFabricacao { get; set; }

        [Required]
        public System.DateTime DataValidade { get; set; }

        [Required]
        public int IdFornecedor { get; set; }
    }
}
