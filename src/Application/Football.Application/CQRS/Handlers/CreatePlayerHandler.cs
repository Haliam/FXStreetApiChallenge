using Football.Application.CQRS.Commands;
using Football.Application.CQRS.Responses;
using Football.Application.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Football.Application.CQRS.Handlers
{
    public class CreatePlayerHandler : IRequestHandler<CreatePlayerCommand, CreatePlayerResponse>
    {
        private IPlayerCommandService _playerCommandService;

        public CreatePlayerHandler(IPlayerCommandService playerCommandService)
        {
            _playerCommandService = playerCommandService;
        }

        public async Task<CreatePlayerResponse> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            return await _playerCommandService.Insert(request, cancellationToken);         
        }
    }
}
