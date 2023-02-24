using Football.Domain.Models;

namespace Football.Infrastructure.Persistence
{
    public interface IPlayerCommandRepository : ICommandRepository<Player>
    {
    }
}
