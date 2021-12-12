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

        public List<Produto> BuscarPorParametros(string descricao)
        {
            //var query = _appDbContext.Set<Fornecedor>().Where(x => x.Descricao == descricao);
            var query = _appDbContext.Set<Produto>().Where(x => EF.Functions.Like(x.Descricao, "%" + descricao.Trim() + "%"));
            if (query.Any())
                return query.ToList();
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
