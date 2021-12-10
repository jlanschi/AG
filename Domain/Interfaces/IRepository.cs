using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoglass.Domain.Interfaces
{
    public interface IRepository
    {
        T BuscarPorID<T>(int id) where T:IBaseEntity ;
        T BuscarPorDescricao<T>(string descricao) where T : IBaseEntity;

        List<T> List<T>() where T : IBaseEntity;

        List<T> List<T> (string descricao) where T : IBaseEntity;

        void Inserir<T>(T entity) where T : IBaseEntity;
        void Editar<T>(T entity) where T : IBaseEntity;
        void Excluir<T>(T entity) where T : IBaseEntity;

    }
}
