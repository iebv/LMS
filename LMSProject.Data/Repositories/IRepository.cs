using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LMSProject.Data.Repositories
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Get(Guid id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> All();
        T Delete(Guid id);
        void SaveChamges();
    }
}
