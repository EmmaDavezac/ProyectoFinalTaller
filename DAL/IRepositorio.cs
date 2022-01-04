using System.Collections.Generic;

namespace DAL
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        void Add(TEntity pEntity);
        void Remove(TEntity pEntity);
        TEntity Get(int pId);
        TEntity Get(string pValor);
        IEnumerable<TEntity> GetAll();
    }
}
