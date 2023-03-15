using Football.Application.CQRS.Commands;
using Football.Application.CQRS.Responses;
using Football.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Football.Application.Services
{
    public interface IPlayerCommandService : ICommandServiceBase<Player>
    {
        Task<CreatePlayerResponse> Insert(CreatePlayerCommand request, CancellationToken cancellationToken);
    }
}
