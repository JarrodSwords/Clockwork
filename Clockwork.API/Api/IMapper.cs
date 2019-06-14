using System;
using Clockwork.API.Domain;
using Clockwork.API.Services;

namespace Clockwork.API
{
    public interface IMapper
    {
        CurrentTimeQueryDto Map(CurrentTimeQuery query);
        TimeZoneDto Map(TimeZoneInfo timezoneInfo);
    }
}
