using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Football.Infrastructure.Persistence
{
    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        private DbSet<T> dbSet;

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate) => await dbSet.Where(predicate).ToListAsync();

        public async Task<IEnumerable<T>> GetAll() => await dbSet.ToListAsync();

        public async Task<T> GetById(int id) => await dbSet.FindAsync(id);
    }
}
