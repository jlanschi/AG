using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T BuscarPorID(int id);

        List<T> Listar();

        void Inserir(T entity);
        void Editar(T entity) ;
        //void Excluir(int id);

    }
}
