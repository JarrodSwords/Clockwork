using System;
using System.Collections.Generic;

namespace Clockwork.API.Services
{
    public class TimeZoneDto
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string StandardName { get; set; }
        public string DaylightName { get; set; }
    }

    public interface ITimeZoneInfoService
    {
        TimeZoneInfo Find(string id);
        ICollection<TimeZoneInfo> Get();
    }
}
