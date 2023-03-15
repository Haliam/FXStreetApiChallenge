using AutoMapper;
using Football.Application.CQRS.Commands;
using Football.Application.CQRS.Responses;
using Football.Domain.Models;
using Football.Infrastructure.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Football.Application.Services
{
    public class PlayerCommandService : CommandServiceBase<Player>, IPlayerCommandService
    {
        public PlayerCommandService(ICommandRepository<Player> commandRepository, IMapper mapper) 
            : base(commandRepository, mapper)
        {
        }

        public async Task<CreatePlayerResponse> Insert(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = _mapper.Map<Player>(request);

            var newPlayer = await _commandRepository.Insert(player);

            await SaveAsync(cancellationToken);

            var createPlayerResponse = _mapper.Map<CreatePlayerResponse>(newPlayer);

            return createPlayerResponse;
        }
    }
}
