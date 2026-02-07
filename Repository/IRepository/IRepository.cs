using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace asprule1020.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        void Add(T entity);
        // update is removed because we are just updating some few entities in registration details and we are not updating the whole entity, so we will just update the properties that we want to update in the registration details and then we will save the changes to the database.
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
