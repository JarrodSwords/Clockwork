using Clockwork.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.API.Implementations
{
    public class BasicTimeZoneInfoService : ITimeZoneInfoService
    {
        public TimeZoneInfo Find(string id)
        {
            return TimeZoneInfo.GetSystemTimeZones()
                .SingleOrDefault(x => x.Id == id);
        }

        public ICollection<TimeZoneInfo> FetchAll()
        {
            return TimeZoneInfo.GetSystemTimeZones()
                .ToList();
        }
    }
}
