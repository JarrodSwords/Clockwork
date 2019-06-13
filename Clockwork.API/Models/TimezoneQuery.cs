using System;

namespace Clockwork.API.Models
{
    public class TimezoneQuery
    {
        public int Id { get; set; }
        public string TimezoneId { get; set; }
        public DateTime RequestTime { get; set; }
        public string ClientIp { get; set; }
    }
}
