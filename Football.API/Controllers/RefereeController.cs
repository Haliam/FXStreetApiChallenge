using Football.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Football.API.Controllers
{
    [Route("/api/referee")]
    [ApiController]
    public class RefereeController : ControllerBase
    {
        public FootballContext FootballContext { get; set; }

        public RefereeController(FootballContext footballContext)
        {
            FootballContext = footballContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Referee>> Get()
        {
            return Ok(FootballContext.Referees);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = FootballContext.Referees.Find(id);

            if (response == null)
                NotFound();

            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Referee referee)
        {
            var response = FootballContext.Referees.Add(referee).Entity;

            if (response == null)
                NotFound();

            return CreatedAtAction("GetById", response.Id, response);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Referee referee)
        {
            if (FootballContext.Referees.Find(id) == null)
                return NotFound();

            FootballContext.Referees.Update(referee);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            if (FootballContext.Referees.Find(id) == null)
                return NotFound();

            Referee referee = FootballContext.Referees.Find(id);

            if (referee == null)
                return NotFound();

            FootballContext.Referees.Remove(referee);

            return Ok();
        }
    }
}
