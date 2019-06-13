using System;
using Clockwork.API.Models;

namespace Clockwork.API
{
    public class PrimitiveMapper
    {
        public static TimezoneDto Map(TimeZoneInfo timezoneInfo) =>
            new TimezoneDto()
            {
                Id = timezoneInfo.Id,
                DisplayName = timezoneInfo.DisplayName,
                StandardName = timezoneInfo.StandardName,
                DaylightName = timezoneInfo.DaylightName
            };
    }
}
