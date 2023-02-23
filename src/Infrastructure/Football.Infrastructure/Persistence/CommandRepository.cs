using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Football.Infrastructure.Persistence
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        public async Task Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
