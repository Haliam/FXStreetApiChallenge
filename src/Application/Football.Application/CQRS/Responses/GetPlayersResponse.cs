using Football.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Application.CQRS.Responses
{
    public class GetPlayersResponse
    {
        public IEnumerable<Player> Players { get; set; }
    }
}
