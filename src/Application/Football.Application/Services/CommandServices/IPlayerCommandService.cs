using Football.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Application.Services
{
    public interface IPlayerCommandService : ICommandServiceBase<Player>
    {
    }
}
