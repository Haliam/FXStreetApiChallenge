using Football.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Football.API.Controllers
{
    [Route("/api/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        readonly FootballContext footballContext;
        public PlayerController(FootballContext footballContext)
        {
            this.footballContext = footballContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            return this.Ok(footballContext.Players);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = footballContext.Players.Find(id);
            if (response == default)
                this.NotFound();
            return this.Ok();
        }

        [HttpPost]
        public ActionResult Post(Player player)
        {
            var response = footballContext.Players.Add(player).Entity;
            return this.CreatedAtAction("GetById", response.Id, response);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Player player)
        {
            if (footballContext.Players.Find(id) == default)
                return this.NotFound();

            footballContext.Players.Update(player);        
            return this.Ok();
        }
    }
}
