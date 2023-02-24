using Football.Domain.Models;

namespace Football.Infrastructure.Persistence
{
    public class PlayerCommandRepository : CommandRepository<Player>, IPlayerCommandRepository
    {
        public PlayerCommandRepository(FootballContext context) 
            : base(context)
        {
        }
    }
}
