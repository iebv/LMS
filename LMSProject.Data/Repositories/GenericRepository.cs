using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMSProject.Data.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T>
        where T : class
    {
        protected LMSProjectDbContext context;

        public GenericRepository(LMSProjectDbContext context)
        {
            this.context = context;
        }

        public virtual T Add(T entity)
        {
            return context.Add<T>(entity).Entity;
        }

        public virtual IEnumerable<T> All()
        {
            return context.Set<T>().ToList();
        }

        public virtual T Delete(Guid id)
        {
            var entity = Get(id);
            return context.Remove(entity).Entity;
        }

        public virtual IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public virtual T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual void SaveChamges()
        {
            context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return context.Update<T>(entity).Entity;
        }
    }
}
