using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Domain.Interfaces
{
    public interface IFornecedorRepository:IRepository
    {
        T BuscarPorID<T>(int id) where T : IFornecedorRepository;
    }


}
