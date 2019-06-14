using System;
using Microsoft.AspNetCore.Mvc;
using Clockwork.API.Domain;
using Clockwork.API.Services;

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class CurrentTimeController : Controller
    {
        private readonly ICurrentTimeQueryService _currentTimeQueryService;
        private readonly ITimeZoneInfoService _timeZoneInfoService;

        public CurrentTimeController(ICurrentTimeQueryService currentTimeQueryService, ITimeZoneInfoService timeZoneInfoService)
        {
            _currentTimeQueryService = currentTimeQueryService;
            _timeZoneInfoService = timeZoneInfoService;
        }

        // GET api/currenttime
        [HttpGet]
        public IActionResult Get()
        {
            var currentTimeQueryDto = _currentTimeQueryService.GetCurrentTime();
            return Ok(currentTimeQueryDto);
        }
        
        // POST api/currenttime
        [HttpPost]
        public IActionResult Post([FromBody] GetCurrentTimeArgs args)
        {
            var currentTimeQueryDto = _currentTimeQueryService.GetCurrentTime(args);
            return Ok(currentTimeQueryDto);
        }
    }
}
