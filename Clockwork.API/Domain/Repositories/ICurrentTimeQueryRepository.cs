using Clockwork.API.Domain;
using System.Collections.Generic;

namespace Clockwork.API.Domain
{
    public interface ICurrentTimeQueryRepository
    {
        CurrentTimeQuery Create(CurrentTimeQuery query);
        ICollection<CurrentTimeQuery> FetchAll();
        CurrentTimeQuery Find(int id);
    }
}
