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
