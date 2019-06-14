using Clockwork.API.Domain;
using System;
using System.Collections.Generic;

namespace Clockwork.API.Services
{
    public class CurrentTimeQueryDto
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string ClientIp { get; set; }
        public DateTime UtcTime { get; set; }
        public TimeZoneDto Timezone { get; set; }
        public DateTime? ConvertedTime =>
            Timezone == null
            ? null
            : (DateTime?)TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Time, Timezone.Id);
    }

    public class GetCurrentTimeArgs
    {
        public string ClientIp { get; set; }
        public string TimeZoneId { get; set; }
    }

    public interface ICurrentTimeQueryService
    {
        ICollection<CurrentTimeQueryDto> GetAllRequests();
        CurrentTimeQueryDto GetCurrentTime(GetCurrentTimeArgs args = null);
    }
}
