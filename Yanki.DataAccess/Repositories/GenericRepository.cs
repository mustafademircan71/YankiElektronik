using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yanki.DataAccess.Abstract;
using Yanki.DataAccess.Concrete;

namespace Yanki.DataAccess.Repositories
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity>
        where TEntity:class
    {
        
        public void Delete(TEntity entity)
        {
            using var c = new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public TEntity Get(Func<TEntity, bool> filter)
        {
            using var c = new Context();
            IQueryable<TEntity> dbSet = c.Set<TEntity>();
            return dbSet.SingleOrDefault(filter);
        }

        public List<TEntity> GetAll()
        {
            using var c = new Context();
            return c.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            using var c = new Context();
            return c.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
