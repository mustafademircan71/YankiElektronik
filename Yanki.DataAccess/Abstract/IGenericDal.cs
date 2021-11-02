using System;
using System.Collections.Generic;
using System.Text;

namespace Yanki.DataAccess.Abstract
{
    public interface IGenericDal<TEntity>
        where TEntity:class
    {
        List<TEntity> GetAll();
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        TEntity Get(Func<TEntity, bool> filter);
    }
}
