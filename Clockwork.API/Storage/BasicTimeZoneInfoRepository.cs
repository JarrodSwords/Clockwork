using Clockwork.API.Domain;
using Clockwork.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.API.Storage
{
    public class BasicTimeZoneInfoService : ITimeZoneInfoService
    {
        public TimeZoneInfo Find(string id)
        {
            return TimeZoneInfo.GetSystemTimeZones()
                .SingleOrDefault(x => x.Id == id);
        }

        public ICollection<TimeZoneInfo> Get()
        {
            return TimeZoneInfo.GetSystemTimeZones()
                .ToList();
        }
    }
}
