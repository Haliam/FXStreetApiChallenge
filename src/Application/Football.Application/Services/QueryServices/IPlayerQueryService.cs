using Football.Application.CQRS.Commands;
using Football.Application.CQRS.Responses;
using Football.Domain.Models;
using System.Threading.Tasks;
using System.Threading;

namespace Football.Application.Services
{
    public interface IPlayerQueryService : IQueryServiceBase<Player>
    {
        Task<GetPlayerByIdResponse> GetById(int id, CancellationToken cancellationToken);
    }
}
