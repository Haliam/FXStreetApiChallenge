using AutoMapper;
using Football.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Football.Application.Services
{
    public class CommandServiceBase<T> : ICommandServiceBase<T> where T : class
    {
        private FootballContext _context;
        public readonly ICommandRepository<T> _commandRepository;
        public readonly IMapper _mapper;

        public CommandServiceBase(ICommandRepository<T> commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public async Task Insert(T entity) => await _commandRepository.Insert(entity);
 
        public async Task InsertRange(IEnumerable<T> entities) => await _commandRepository.InsertRange(entities);

        public async Task Update(T entity) => await _commandRepository.Update(entity);

        public async Task Delete(T entity) => await _commandRepository.Delete(entity);

        public async Task Delete(object id) => await _commandRepository.Delete(id);

        public async Task DeleteRange(IEnumerable<T> entities) => await _commandRepository.Delete(entities);

        public async Task SaveAsync(CancellationToken cancellationToken) => await _context.SaveChangesAsync();
    }
}