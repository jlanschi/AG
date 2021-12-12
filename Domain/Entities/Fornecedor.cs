using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Domain.Entities
{
    public class Fornecedor:BaseEntity
    {
        public string Descricao { get; set; }
        public string Cnpj { get; set; }

        public string Tipo { get; set; }


        public Fornecedor() { }

        public Fornecedor(string descricao, string cNPJ, string tipo) 
        { 
            Descricao = descricao;
            Cnpj = cNPJ;
            Tipo = tipo;
            Situacao = 1; //ativo
        }

        public bool MarcarInativo() 
        {
            Situacao = 0; //inativo
            return true;
        }
    }
}
