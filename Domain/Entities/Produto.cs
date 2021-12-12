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

        private DateTime _dataFabricacao;
        private DateTime _dataValidade;

        public DateTime DataFabricacao 
        {
          get { return _dataFabricacao; } 
            
          set 
            {
                if (ValidaData(value, _dataValidade))
                    { _dataFabricacao = value; }
                else
                    { throw new ArgumentException("Data de Fabricação deve ser menor que a data de Validade."); }
            } 
        }
        public DateTime DataValidade 
        {
            get { return _dataValidade; }

            set
            {
                if (ValidaData(_dataFabricacao, value))
                { _dataValidade = value; }
                else
                { throw new ArgumentException("Data de Validade deve ser maior que a data de Fabricação."); }
            }
        }
        public int IdFornecedor { get; set; }

        public Produto() 
        { }

        public Produto(string descricao, DateTime dataFabricacao, DateTime dataValidade, int idFornecedor) 
        { 
            Descricao = descricao;
            Situacao = 1; //Ativo
            DataFabricacao = dataFabricacao;
            DataValidade = dataValidade;
            IdFornecedor = idFornecedor;
        }

        private bool ValidaData(DateTime fabricacao, DateTime validade) 
        {
            bool retorno = true;

            if (fabricacao != DateTime.MinValue && validade != DateTime.MinValue)
            { retorno = fabricacao < validade; }
            else { retorno = true; }

            return retorno;
        }

        public bool MarcarInativo() 
        {
            Situacao = 0; //inativo
            return true;
        }

    }
}
