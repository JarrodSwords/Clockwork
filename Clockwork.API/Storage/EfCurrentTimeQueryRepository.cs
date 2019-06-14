using Clockwork.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.API.Storage
{
    public class EfCurrentTimeQueryRepository : ICurrentTimeQueryRepository
    {
        public CurrentTimeQuery Create(CurrentTimeQuery query)
        {
            using (var db = new ClockworkContext())
            {
                db.CurrentTimeQueries.Add(query);
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                foreach (var CurrentTimeQuery in db.CurrentTimeQueries)
                    Console.WriteLine(" - {0}", CurrentTimeQuery.UTCTime);

                return query;
            }
        }

        public CurrentTimeQuery Find(int id)
        {
            using (var db = new ClockworkContext())
                return db.CurrentTimeQueries.Find(id);
        }

        public ICollection<CurrentTimeQuery> Get()
        {
            using (var db = new ClockworkContext())
                return db.CurrentTimeQueries.ToList();
        }
    }
}
