using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Football.Infrastructure.Persistence
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        private FootballContext context;
        private DbSet<T> dbSet;

        public async Task Insert(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public async Task Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(object id)
        {
            var entity = dbSet.FindAsync(id);

            await Delete(entity.Result);
        }

        public async Task DeleteRange(IEnumerable<T> entities)
        {     
            context.Set<T>().RemoveRange(entities);
            await context.SaveChangesAsync();
        }
    }
}
