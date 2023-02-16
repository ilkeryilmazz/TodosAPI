using System.Linq.Expressions;

namespace Core.DataAccess;

public interface IAsyncEntityRepository<TEntity>
{
    public Task<TEntity> AddAsync(TEntity entity);
    public Task<List<TEntity>> AddMultipleAsync(List<TEntity> entities);
    public Task<TEntity> UpdateAsync(TEntity entity);
    public Task<List<TEntity>> UpdateMultipleAsync(List<TEntity> entities);
    public Task<List<TEntity>> DeleteMultipleAsync(List<TEntity> entities);
    public Task<TEntity> DeleteAsync(TEntity entity);
    public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null);
    public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
}