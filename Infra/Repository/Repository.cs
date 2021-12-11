using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Autoglass.Domain.Entities;
using Autoglass.Domain.Interfaces;
using Autoglass.Infra.Context;

namespace Autoglass.Infra.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext) { _appDbContext = appDbContext; }

        public  T BuscarPorID(int id) 
        {
            return _appDbContext.Set<T>().FirstOrDefault(e => e.Id == id);
        }

        public List<T> Listar()
        {
            var query = _appDbContext.Set<T>();
            if (query.Any())
                return query.ToList();
            return new List<T>();
        }

        public void Inserir(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
            _appDbContext.SaveChanges();
        }
    }
}
