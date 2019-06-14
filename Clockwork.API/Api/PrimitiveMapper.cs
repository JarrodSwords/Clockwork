using System;
using Clockwork.API.Domain;
using Clockwork.API.Services;

namespace Clockwork.API
{
    public class PrimitiveMapper : IMapper
    {
        private readonly ITimeZoneInfoService _timeZoneInfoService;

        public PrimitiveMapper(ITimeZoneInfoService timeZoneInfoService)
        {
            _timeZoneInfoService = timeZoneInfoService;
        }

        public TimeZoneDto Map(TimeZoneInfo timezoneInfo) =>
            new TimeZoneDto()
            {
                Id = timezoneInfo.Id,
                DisplayName = timezoneInfo.DisplayName,
                StandardName = timezoneInfo.StandardName,
                DaylightName = timezoneInfo.DaylightName
            };

        public CurrentTimeQueryDto Map(CurrentTimeQuery query)
        {
            var timezone = _timeZoneInfoService.Find(query.TimeZoneId);
            var timeZoneDto = timezone == null
                ? null
                : Map(timezone);

            return new CurrentTimeQueryDto
            {
                Id = query.CurrentTimeQueryId,
                ClientIp = query.ClientIp,
                Time = query.Time,
                Timezone = timeZoneDto,
                UtcTime = query.UTCTime
            };
        }
    }
}
