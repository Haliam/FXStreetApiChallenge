using Football.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Football.API.Controllers
{
    [Route("/api/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        public FootballContext FootballContext { get; set; }

        public PlayerController(FootballContext footballContext)
        {
            FootballContext = footballContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            return Ok(FootballContext.Players);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = FootballContext.Players.Find(id);

            if (response == null)
                NotFound();

            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Player player)
        {
            var response = FootballContext.Players.Add(player).Entity;

            if (response == null)
                NotFound();

            return CreatedAtAction("GetById", response.Id, response);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Player player)
        {
            if (FootballContext.Players.Find(id) == null)
                return NotFound();

            FootballContext.Players.Update(player); 
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            if (FootballContext.Players.Find(id) == null)
                return NotFound();

            Player player = FootballContext.Players.Find(id);

            if (player == null)
                return NotFound();

            FootballContext.Players.Remove(player);

            return Ok();
        }
    }
}
