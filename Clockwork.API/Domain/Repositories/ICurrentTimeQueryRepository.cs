using Clockwork.API.Domain;
using System.Collections.Generic;

namespace Clockwork.API.Domain
{
    public interface ICurrentTimeQueryRepository
    {
        CurrentTimeQuery Create(CurrentTimeQuery query);
        CurrentTimeQuery Find(int id);
        ICollection<CurrentTimeQuery> Get();
    }
}
