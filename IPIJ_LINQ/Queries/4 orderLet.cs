using System;
using System.Linq;

using ITSILESIA.IPIJ_LINQ.Model;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    static class LetOrder
    {
        public static void Run()
        {
            var query = from user in SampleData.AllUsers
                        join defect in SampleData.AllDefects on user equals defect.AssignedTo into defects
                        let count = defects.Count()
                        orderby count descending, user.Name
                        select new { User = user, Count = count };

            // var avg = query.Average(x => x.Count); TODO
            // Console.WriteLine(avg);

            foreach (var userAndCount in query)
            {
                Console.WriteLine("{0}: {1}", userAndCount.User.Name, userAndCount.Count);
            }
        }
    }
}
