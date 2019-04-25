using System.Collections.Generic;

namespace MyWebsite.Core
{
    public interface IGenericRepository<TEntity>
    {
        int Add(TEntity entity);
        bool Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        bool Update(TEntity entity);
    }
}
