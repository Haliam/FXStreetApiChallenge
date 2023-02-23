using Football.Domain.Models;
using Football.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Football.API.Controllers
{
    [Route("/api/match")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        public FootballContext FootballContext { get; set; }

        public MatchController(FootballContext footballContext)
        {
            FootballContext = footballContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Match>> Get()
        {
            return Ok(FootballContext.Matches);
        }
        
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = FootballContext.Matches.Find(id);

            if (response == null)
                NotFound();

            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Match match)
        {
            var response = FootballContext.Matches.Add(match).Entity;

            if (response == null)
                NotFound();

            return CreatedAtAction("GetById", response.Id, response);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Match match)
        {
            if (FootballContext.Matches.Find(id) == null)
                return NotFound();

            FootballContext.Matches.Update(match);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            if (FootballContext.Matches.Find(id) == null)
                return NotFound();

            Match match = FootballContext.Matches.Find(id);

            if (match == null)
                return NotFound();

            FootballContext.Matches.Remove(match);

            return Ok();
        }
    }
}
