﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace Football.API.Controllers
{
    [Route("/api/statistics")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        public FootballContext FootballContext { get; set; }

        public StatisticsController(FootballContext footballContext)
        {
            FootballContext = footballContext;
        }

        [HttpGet]
        [Route("yellowcards")]
        public ActionResult GetYellowCards()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("redcards")]
        public ActionResult GetRedCards()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("minutesplayed")]
        public ActionResult GetMinutesPlayed()
        {
            throw new NotImplementedException();
        }
    }
}
