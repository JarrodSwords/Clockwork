using Clockwork.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Clockwork.API.Controllers
{
    [Route("api/[controller]")]
    public class CurrentTimeQueriesController : Controller
    {
        // GET api/currenttimequeries
        [HttpGet]
        public IActionResult Get()
        {
            using (var db = new ClockworkContext())
            {
                var apiRequests = db.CurrentTimeQueries.ToList();
                return Ok(apiRequests);
            }
        }
    }
}
