using Autoglass.Domain.Entities;

namespace Autoglass.API.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public SituacaoProduto Situacao { get; set; }

        public string DataFabricacao { get; set; }
        public string DataValidade { get; set; }

        //public DateTime DataFabricacao { get; set; }
        //public DateTime DataValidade { get; set; }
        public FornecedorModel Fornecedor { get; set; }
    }
}
