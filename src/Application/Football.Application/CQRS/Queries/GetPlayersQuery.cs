using Football.Application.CQRS.Responses;
using Football.Domain.Models;
using MediatR;
using System.Collections;
using System.Collections.Generic;

namespace Football.Application.CQRS.Queries
{
    public class GetPlayersQuery : IRequest<GetPlayersResponse>
    {
    }
}