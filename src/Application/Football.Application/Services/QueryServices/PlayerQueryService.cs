using Football.Domain.Models;
using Football.Infrastructure.Persistence;

namespace Football.Application.Services
{
    public class PlayerQueryService : QueryServiceBase<Player>, IPlayerQueryService
    {
        public PlayerQueryService(IQueryRepository<Player> queryRepository) 
            : base(queryRepository)
        {
        }
    }
}
