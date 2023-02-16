using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> :   IEntityRepository<TEntity>, IAsyncEntityRepository<TEntity> where TEntity:class,new() where TContext:DbContext
    {
        private TContext Context { get; }

        public EfEntityRepositoryBase(TContext context)
        {
            Context = context;
        }
        public TEntity Add(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            Context.SaveChanges();
            return entity;
        }

        public List<TEntity> AddMultiple(List<TEntity> entities)
        {
            Context.Entry(entities).State = EntityState.Added;
            Context.SaveChanges();
            return entities;
        }

        public TEntity Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
            return entity;
        }

        public List<TEntity> UpdateMultiple(List<TEntity> entities)
        {
            Context.Entry(entities).State = EntityState.Modified;
            Context.SaveChanges();
            return entities;
        }

        public TEntity Delete(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();
            return entity;
        }

        public List<TEntity> DeleteMultiple(List<TEntity> entities)
        {
            Context.Entry(entities).State = EntityState.Deleted;
            Context.SaveChanges();
            return entities;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter != null ? Context.Set<TEntity>().Where(filter).ToList() : Context.Set<TEntity>().ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return Context.Set<TEntity>().Where(filter).FirstOrDefault();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> AddMultipleAsync(List<TEntity> entities)
        {
            Context.Entry(entities).State = EntityState.Added;
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> UpdateMultipleAsync(List<TEntity> entities)
        {
            Context.Entry(entities).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<List<TEntity>> DeleteMultipleAsync(List<TEntity> entities)
        {
            Context.Entry(entities).State = EntityState.Deleted;
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter !=null ? await Context.Set<TEntity>().Where(filter).ToListAsync(): await Context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await Context.Set<TEntity>().Where(filter).FirstOrDefaultAsync();
        }
    }
}
