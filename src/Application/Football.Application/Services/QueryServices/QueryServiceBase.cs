using Football.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Football.Application.Services
{
    public class QueryServiceBase<T> : IQueryServiceBase<T> where T : class
    {
        private readonly IQueryRepository<T> _queryRepository;

        public QueryServiceBase(IQueryRepository<T> queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate) => await _queryRepository.Find(predicate);

        public async Task<IEnumerable<T>> GetAll() => await _queryRepository.GetAll();

        public async Task<T> GetById(int id) => await _queryRepository.GetById(id);
    }
}
