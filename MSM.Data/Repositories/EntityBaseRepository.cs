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

        private MultisiteDBEntitiesContext context;

        public MultisiteDBEntitiesContext Context { get => context; set => context = value; }

        #region Properties
        public EntityBaseRepository(MultisiteDBEntitiesContext context)
        {
            this.context = context;
        }
        #endregion
        public virtual Task<IQueryable<T>> GetAll()
        {
            IQueryable<T> query = context.Set<T>();
            return Task.FromResult(query);
        }

        public virtual int Count()
        {
            return context.Set<T>().Count();
        }

        public virtual async Task<IQueryable<T>> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await Task.FromResult(query);
        }

        public async Task<T> GetSingle(Expression<Func<T, bool>> predicate)
        {
            return await Task.FromResult(context.Set<T>().FirstOrDefault(predicate));
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return query.Where(predicate).FirstOrDefault();
        }

        public virtual async Task<IQueryable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            return await Task.FromResult(context.Set<T>().Where(predicate));
        }

        public virtual void Add(T entity)
        {
            EntityEntry dbEntityEntry = context.Entry<T>(entity);
            context.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            EntityEntry dbEntityEntry = context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            EntityEntry dbEntityEntry = context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public virtual void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = context.Set<T>().Where(predicate);

            foreach (var entity in entities)
            {
                context.Entry<T>(entity).State = EntityState.Deleted;
            }
        }

        public virtual void Commit()
        {
            context.SaveChanges();
        }
    }
}
