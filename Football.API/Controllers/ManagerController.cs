using Football.Domain.Models;
using Football.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Football.API.Controllers
{
    [Route("/api/manager")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        public FootballContext FootballContext { get; set; }

        public ManagerController(FootballContext footballContext)
        {
            FootballContext = footballContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Manager>> Get()
        {
            return Ok(FootballContext.Managers);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var response = FootballContext.Managers.Find(id);

            if (response == null)
                NotFound();

            return Ok();
        }

        [HttpPost]
        public ActionResult Post(Manager manager)
        {
            var response = FootballContext.Managers.Add(manager).Entity;

            if (response == null)
                NotFound();

            return CreatedAtAction("GetById", response.Id, response);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Manager manager)
        {
            if (FootballContext.Managers.Find(id) == null)
                return NotFound();

            FootballContext.Managers.Update(manager);     
            
            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            if (FootballContext.Managers.Find(id) == null)
                return NotFound();

            Manager manager = FootballContext.Managers.Find(id); 

            if (manager == null)
                return NotFound();

            FootballContext.Managers.Remove(manager);

            return Ok();
        }
    }
}
