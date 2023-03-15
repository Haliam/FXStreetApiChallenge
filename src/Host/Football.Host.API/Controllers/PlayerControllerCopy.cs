using Football.Application.CQRS.Commands;
using Football.Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Football.API.Controllers
{
    [Route("/api/player")]
    [ApiController]
    public class PlayerControllerCopy : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlayerControllerCopy(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetPlayersQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            return Ok(await _mediator.Send(new GetPlayerByIdQuery(id)));
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreatePlayerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] UpdatePlayerCommand command)
        {
            return Ok(await _mediator.Send(command.Id = id));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            return Ok(await _mediator.Send(new DeletePlayerCommand(id)));
        }
    }
}
