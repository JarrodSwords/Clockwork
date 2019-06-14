using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Clockwork.API.Services;
using Clockwork.API.Domain;

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class TimezonesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITimeZoneInfoService _timeZoneInfoService;

        public TimezonesController(IMapper mapper, ITimeZoneInfoService timeZoneInfoService)
        {
            _mapper = mapper;
            _timeZoneInfoService = timeZoneInfoService;
        }

        // GET api/timezones
        [HttpGet]
        public IActionResult Get()
        {
            var timeZoneDtos = _timeZoneInfoService.FetchAll()
                .Select(x => _mapper.Map(x));

            return Ok(timeZoneDtos);
        }
    }
}
