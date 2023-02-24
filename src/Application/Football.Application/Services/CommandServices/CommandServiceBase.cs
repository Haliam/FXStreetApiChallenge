using Football.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Football.Application.Services
{
    public class CommandServiceBase<T> : ICommandServiceBase<T> where T : class
    {
        private ICommandRepository<T> _commandRepository; 

        public CommandServiceBase(ICommandRepository<T> commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public async Task Insert(T entity) => await _commandRepository.Insert(entity);
 
        public async Task InsertRange(IEnumerable<T> entities) => await _commandRepository.InsertRange(entities);

        public async Task Update(T entity) => await _commandRepository.Update(entity);

        public async Task Delete(T entity) => await _commandRepository.Delete(entity);

        public async Task Delete(object id) => await _commandRepository.Delete(id);

        public async Task DeleteRange(IEnumerable<T> entities) => await _commandRepository.Delete(entities);
    }
}