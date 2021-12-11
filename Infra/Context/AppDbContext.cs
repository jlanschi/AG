using Autoglass.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Autoglass.Infra.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
