using System;

namespace Clockwork.API.Models
{
    public class TimezoneDto
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string StandardName { get; set; }
        public string DaylightName { get; set; }
    }

    public class TimezoneQuery
    {
        public int Id { get; set; }
        public string TimezoneId { get; set; }
        public DateTime RequestTime { get; set; }
        public string ClientIp { get; set; }
    }
}
