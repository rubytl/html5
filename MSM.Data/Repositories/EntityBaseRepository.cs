using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
         where T : class, new()
    {
        protected readonly Func<MultisiteDBEntitiesContext> contextFactory;

        protected MultisiteDBEntitiesContext Context
        {
            get
            {
                return this.contextFactory.Invoke();
            }
        }

        #region Properties
        public EntityBaseRepository(Func<MultisiteDBEntitiesContext> context)
        {
            this.contextFactory = context;
        }

        #endregion
        public virtual async Task<IQueryable<T>> GetAll()
        {
            IQueryable<T> query = Context.Set<T>();
            return await Task.FromResult(query);
        }

        public virtual int Count()
        {
            return Context.Set<T>().Count();
        }

        public virtual async Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await this.Context.Set<T>().Where(predicate).CountAsync();
        }

        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.Where(predicate).FirstOrDefaultAsync();
        }

        public virtual async Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await Task.FromResult(Context.Set<T>().Where(predicate));
        }

        public virtual void Add(T entity)
        {
            EntityEntry dbEntityEntry = Context.Entry<T>(entity);
            Context.Set<T>().AddAsync(entity);
        }

        public virtual void Update(T entity)
        {
            EntityEntry dbEntityEntry = Context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            EntityEntry dbEntityEntry = Context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public virtual void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = Context.Set<T>().Where(predicate);

            foreach (var entity in entities)
            {
                Context.Entry<T>(entity).State = EntityState.Deleted;
            }
        }

        public virtual void Commit()
        {
            this.Context.SaveChangesAsync();
        }
    }
}
