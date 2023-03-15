using Football.Application.CQRS.Responses;
using MediatR;

namespace Football.Application.CQRS.Commands
{
    public class DeletePlayerCommand : IRequest<DeletePlayerResponse>
    {
        public int Id { get; set; }

        public DeletePlayerCommand(int id)
        {
            Id = id;
        }
    }
}
