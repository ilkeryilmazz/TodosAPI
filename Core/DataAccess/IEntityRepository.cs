using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity>
    {
        public TEntity Add(TEntity entity);
        public List<TEntity> AddMultiple(List<TEntity> entities);
        public TEntity Update(TEntity entity);
        public List<TEntity> UpdateMultiple(List<TEntity> entities);
        public TEntity Delete(TEntity entity);
        public List<TEntity> DeleteMultiple(List<TEntity> entities);
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        public TEntity Get(Expression<Func<TEntity, bool>> filter);
    }
}
