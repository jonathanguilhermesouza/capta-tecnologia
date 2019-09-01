using System;
using System.Linq;
using System.Linq.Expressions;

namespace CaptaTecnologia.Data.Repositories.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity FindByKey(params object[] key);
        TEntity GetObject(Expression<Func<TEntity, bool>> predicateWhere);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicateWhere = null);
        void Add(TEntity obj);
        void Delete(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity obj);
        void Save();

    }
}
