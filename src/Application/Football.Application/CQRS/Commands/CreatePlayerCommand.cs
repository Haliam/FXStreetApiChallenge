using Football.Application.CQRS.Responses;
using MediatR;
using System;

namespace Football.Application.CQRS.Commands
{
    public class CreatePlayerCommand : IRequest<CreatePlayerResponse>
    {
        public string Name { get; set; }

        public int YellowCard { get; set; }

        public int RedCard { get; set; }

        public int MinutesPlayed { get; set; }

        public DateTime CreateDate { get; set; }

        public CreatePlayerCommand()
        {
            CreateDate = DateTime.Now;
        }
    }
}
