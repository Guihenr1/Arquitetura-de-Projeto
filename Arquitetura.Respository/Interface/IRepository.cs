using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Respository.Interface
{
    public interface IRepository<T>
    {
        void inserir(T entidade);
        void Excluir(T entidade);
        void Alterar(T entidade);
        void ListaPorCodigo(int codigo);
    }
}
