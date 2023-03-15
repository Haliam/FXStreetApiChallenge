using Football.Domain.Models;

namespace Football.Application.CQRS.Responses
{
    public class GetPlayerByIdResponse
    {
        public Player Player { get; set; }
    }
}