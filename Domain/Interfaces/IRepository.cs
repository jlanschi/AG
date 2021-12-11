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
        //T BuscarPorDescricao(string descricao);

        List<T> Listar();

        //List<T> Listar(string descricao);

        void Inserir(T entity);
        //void Editar(T entity) ;
        //void Excluir(T entity);

    }
}
