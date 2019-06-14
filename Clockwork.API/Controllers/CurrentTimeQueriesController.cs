using Clockwork.API.Domain;
using Clockwork.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class CurrentTimeQueriesController : Controller
    {
        private readonly ICurrentTimeQueryService _currentTimeQueryService;

        public CurrentTimeQueriesController(ICurrentTimeQueryService currentTimeQueryService)
        {
            _currentTimeQueryService = currentTimeQueryService;
        }

        // GET api/currenttimequeries
        [HttpGet]
        public IActionResult Get()
        {
            var requests = _currentTimeQueryService.GetAllRequests();
            return Ok(requests);
        }
    }
}
