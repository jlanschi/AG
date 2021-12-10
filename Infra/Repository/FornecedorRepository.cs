using Microsoft.EntityFrameworkCore;
using Autoglass.Domain.Interfaces;
using Autoglass.Domain.Entities;
using Autoglass.Infra.Context;

namespace Autoglass.Infra.Repository
{
    public class FornecedorRepository:IFornecedorRepository
    {
        private readonly AppDbContext _dbContext;

        public FornecedorRepository(AppDbContext dbContext) { _dbContext = dbContext; }

        public T BuscarPorID<T>(int id) where T:Fornecedor
        { 

        }
    }
}
