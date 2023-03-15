using AutoMapper;
using Football.Application.CQRS.Responses;
using Football.Domain.Models;
using Football.Infrastructure.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Football.Application.Services
{
    public class PlayerQueryService : QueryServiceBase<Player>, IPlayerQueryService
    {
        public PlayerQueryService(IQueryRepository<Player> queryRepository, IMapper mapper) 
            : base(queryRepository, mapper)
        {
        }

        public async Task<GetPlayerByIdResponse> GetById(int id, CancellationToken cancellationToken)
        {
            var player = await _queryRepository.GetById(id);

            var getPlayerByIdResponse = _mapper.Map<GetPlayerByIdResponse>(player);

            return getPlayerByIdResponse;
        }
    }
}
