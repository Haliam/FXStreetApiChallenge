using Football.Application.CQRS.Responses;
using Football.Domain.Models;
using MediatR;

namespace Football.Application.CQRS.Queries
{
    public class GetPlayerByIdQuery : IRequest<GetPlayerByIdResponse>
    {
        public int Id { get; set; }

        public GetPlayerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
