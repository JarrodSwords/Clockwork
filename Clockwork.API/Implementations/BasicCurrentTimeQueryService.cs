using Clockwork.API.Domain;
using Clockwork.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.API.Implementations
{
    public class BasicCurrentTimeQueryService : ICurrentTimeQueryService
    {
        private readonly ICurrentTimeQueryRepository _repository;
        private readonly IMapper _mapper;

        public BasicCurrentTimeQueryService(ICurrentTimeQueryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ICollection<CurrentTimeQueryDto> GetAllRequests()
        {
            return _repository.Get()
                .Select(x => _mapper.Map(x))
                .ToList();
        }

        public CurrentTimeQueryDto GetCurrentTime(GetCurrentTimeArgs args)
        {
            var serverTime = DateTime.Now;
            
            var query = new CurrentTimeQuery
            {
                ClientIp = args.ClientIp,
                Time = serverTime,
                TimeZoneId = args.TimeZoneId,
                UTCTime = serverTime.ToUniversalTime()
            };

            return _mapper.Map(_repository.Create(query));
        }
    }
}
