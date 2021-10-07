using System.Collection.Generics;

namespace Series.Dio.Interfaces
{
    public interface IRepositorio<T>
    {

        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(in id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    
    }

}