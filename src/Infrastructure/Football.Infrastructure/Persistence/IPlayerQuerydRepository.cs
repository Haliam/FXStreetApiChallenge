using Football.Domain.Models;

namespace Football.Infrastructure.Persistence
{
    public interface IPlayerQueryRepository : IQueryRepository<Player>
    {
    }
}
