using Football.Application.CQRS.Queries;
using Football.Application.CQRS.Responses;
using Football.Application.Services;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Football.Application.CQRS.Handlers
{
    public class GetPlayerByIdHandler : IRequestHandler<GetPlayerByIdQuery, GetPlayerByIdResponse>
    {
        private IPlayerQueryService _playerQueryService;

        public GetPlayerByIdHandler(IPlayerQueryService playerQueryService)
        {
            _playerQueryService = playerQueryService;
        }

        public async Task<GetPlayerByIdResponse> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
        {
            return await _playerQueryService.GetById(request.Id, cancellationToken);
        }
    }
}
