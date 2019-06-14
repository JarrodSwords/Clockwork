using Clockwork.API.Domain;
using Clockwork.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.API.Implementations
{
    public class BasicCurrentTimeQueryService : ICurrentTimeQueryService
    {
        private readonly IMapper _mapper;
        private readonly ICurrentTimeQueryRepository _repository;

        public BasicCurrentTimeQueryService(IMapper mapper, ICurrentTimeQueryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public ICollection<CurrentTimeQueryDto> GetAllRequests()
        {
            return _repository.FetchAll()
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
