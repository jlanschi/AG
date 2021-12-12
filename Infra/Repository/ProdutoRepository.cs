using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Autoglass.Domain.Entities;
using Autoglass.Domain.Interfaces;
using Autoglass.Infra.Context;

namespace Autoglass.Infra.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public List<Produto> BuscarPorParametros(string descricao, int fornecedor, int pageSize, int page)
        {

            IQueryable<Produto> query = _appDbContext.Set<Produto>();

            //query = query.Where(x => x.Descricao == descricao);
            if (!string.IsNullOrEmpty(descricao)) 
                query = query.Where(x => EF.Functions.Like(x.Descricao,"%"+descricao.Trim()+"%"));
            if (fornecedor != null && fornecedor>0)
                query = query.Where(x => x.IdFornecedor == fornecedor);
            if (query.Any())
                return query.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new List<Produto>();
        }

        public void Excluir(int id)
        {
            var original = BuscarPorID(id);

            if (original != null)
            {
                original.MarcarInativo();
                _appDbContext.SaveChanges();
            }
        }
    }
}
