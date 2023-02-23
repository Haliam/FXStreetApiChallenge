using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Football.Infrastructure.Persistence
{
    public interface IQueryRepository<T>
    {
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);
    }
}
