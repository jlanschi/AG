using Autoglass.Domain.Entities;

namespace Autoglass.API.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Situacao { get; set; }

        public System.DateTime DataFabricacao { get; set; }
        public System.DateTime DataValidade { get; set; }

        //public DateTime DataFabricacao { get; set; }
        //public DateTime DataValidade { get; set; }
        public int IdFornecedor { get; set; }
    }
}
