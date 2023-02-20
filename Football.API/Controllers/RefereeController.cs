using Football.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Football.API.Controllers
{
    [Route("/api/referee")]
    [ApiController]
    public class RefereeController : ControllerBase
    {
        readonly FootballContext footballContext;
        public RefereeController(FootballContext footballContext)
        {
            this.footballContext = footballContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Referee>> Get()
        {
            return this.Ok(footballContext.Referees);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = footballContext.Referees.Find(id);
            if (response == default)
                this.NotFound();
            return this.Ok();
        }

        [HttpPost]
        public ActionResult Post(Referee referee)
        {
            var response = footballContext.Referees.Add(referee).Entity;
            return this.CreatedAtAction("GetById", response.Id, response);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Referee referee)
        {
            if (footballContext.Referees.Find(id) == default)
                return this.NotFound();

            footballContext.Referees.Update(referee);        
            return this.Ok();
        }
    }
}
