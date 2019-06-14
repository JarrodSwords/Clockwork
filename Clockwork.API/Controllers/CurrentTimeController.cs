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

        public CurrentTimeController(ICurrentTimeQueryService currentTimeQueryService)
        {
            _currentTimeQueryService = currentTimeQueryService;
        }

        // GET api/currenttime
        [HttpGet]
        public IActionResult Get()
        {
            var args = new GetCurrentTimeArgs { ClientIp = GetClientIp() };
            return Ok(_currentTimeQueryService.GetCurrentTime(args));
        }

        // POST api/currenttime
        [HttpPost]
        public IActionResult Post([FromBody] GetCurrentTimeArgs args)
        {
            args.ClientIp = GetClientIp();
            return Ok(_currentTimeQueryService.GetCurrentTime(args));
        }

        private string GetClientIp() =>
            this.HttpContext.Connection.RemoteIpAddress.ToString();
    }
}
