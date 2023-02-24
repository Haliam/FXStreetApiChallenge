using Football.Domain.Models;

namespace Football.Infrastructure.Persistence
{
    public class PlayerQueryRepository : QueryRepository<Player>, IPlayerQueryRepository
    {
        public PlayerQueryRepository(FootballContext context) : base(context)
        {
        }
    }
}
