using System.Collections.Generic;

namespace MyWebsite.Core.Services
{
    public interface IBaseService<TEntity>
    {
        int Add(TEntity entity);
        bool Delete(object id);
        bool Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        bool Update(TEntity entity); 
    }
}
