using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Domain.Entities
{
    public class Produto:BaseEntity
    {
        public string Descricao { get; set; }

        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int IdFornecedor { get; set; }

        public Produto() 
        { }

        public Produto(string descricao, int situacao, DateTime dataFabricacao, DateTime dataValidade, int idFornecedor) 
        { 
            Descricao = descricao;
            Situacao = 1; //Ativo
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            IdFornecedor = idFornecedor;
        }


    }
}
