using Football.Application.CQRS.Responses;
using MediatR;

namespace Football.Application.CQRS.Commands
{
    public class UpdatePlayerCommand : IRequest<UpdatePlayerResponse>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int YellowCard { get; set; }

        public int RedCard { get; set; }

        public int MinutesPlayed { get; set; }

        public UpdatePlayerCommand(int id, string name, int yellowCard, int redCard, int minutesPlayed)
        {
            Id = id;
            Name = name;
            YellowCard = yellowCard;
            RedCard = redCard;
            MinutesPlayed = minutesPlayed;
        }
    }
}
