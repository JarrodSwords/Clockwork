using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class TimezonesController : Controller
    {
        // GET api/timezones
        [HttpGet]
        public IActionResult Get()
        {
            var timezones = TimeZoneInfo.GetSystemTimeZones()
                .Select(x => PrimitiveMapper.Map(x))
                .ToList();

            return Ok(timezones);
        }
    }
}
