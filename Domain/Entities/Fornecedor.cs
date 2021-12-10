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

        public Fornecedor(string descricao, string cNPJ) 
        { 
            Descricao = descricao;
            Cnpj = cNPJ;    
        }
    }
}
