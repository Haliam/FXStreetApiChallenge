using Football.Domain.Models;
using Football.Infrastructure.Persistence;

namespace Football.Application.Services
{
    public class PlayerCommandService : CommandServiceBase<Player>, IPlayerCommandService
    {
        public PlayerCommandService(ICommandRepository<Player> commandRepository) 
            : base(commandRepository)
        {
        }
    }
}
