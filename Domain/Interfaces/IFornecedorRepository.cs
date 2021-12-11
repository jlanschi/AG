using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autoglass.Domain.Entities;

namespace Autoglass.Domain.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor> 
    {
        public List<Fornecedor> BuscarPorDescricao(string descricao);
    }
}
