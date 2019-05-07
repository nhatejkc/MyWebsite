using System;
using System.Collections.Generic;

namespace MyWebsite.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _genericRepository;

        public BaseService(IGenericRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public int Add(TEntity entity)
        {
            return _genericRepository.Add(entity);
        }

        public bool Delete(TEntity entity)
        {
            return _genericRepository.Delete(entity);
        }

        public bool Delete(object id)
        {
            if (id == null)
            {
                throw new Exception("ID null roi");
            }
            var entity = GetById(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            return Delete(entity);

        }

        public IEnumerable<TEntity> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public TEntity GetById(object id)
        {
            if (id == null)
            {
                throw new Exception("ID null roi");
            }
            return _genericRepository.GetById(id);
        }

        public bool Update(TEntity entity)
        {
            return _genericRepository.Update(entity);
        }
    }
}
