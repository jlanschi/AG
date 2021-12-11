using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Autoglass.Domain.Entities;
using Autoglass.Domain.Interfaces;
using Autoglass.Infra.Context;

namespace Autoglass.Infra.Repository
{
    public class FornecedorRepository:Repository<Fornecedor>,IFornecedorRepository
    {
        public FornecedorRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public List<Fornecedor> BuscarPorDescricao(string descricao)
        {
            //var query = _appDbContext.Set<Fornecedor>().Where(x => x.Descricao == descricao);
            var query = _appDbContext.Set<Fornecedor>().Where(x => EF.Functions.Like(x.Descricao, "%"+descricao.Trim()+"%"));
            if (query.Any())
                return query.ToList();
            return new List<Fornecedor>();
        }
    }
}
