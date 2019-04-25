using MyWebsite.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace MyWebsite.Core
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly MyWebsiteDbContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(MyWebsiteDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public virtual int Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return _context.SaveChanges();
        }

        public virtual bool Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual bool Update(TEntity entity)
        {
            _dbSet.AddOrUpdate(entity);
            return _context.SaveChanges() > 0;
        }

    }
}
