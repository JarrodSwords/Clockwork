using System;
using Microsoft.AspNetCore.Mvc;
using Clockwork.API.Models;

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class TimezonesController : Controller
    {
        // GET api/timezones
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(TimeZoneInfo.GetSystemTimeZones());
        }
    }
}
