using System;
using System.ComponentModel;
using System.Linq;

using ITSILESIA.IPIJ_LINQ.Model;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    class WhereWhereOrder
    {
        public static void Run()
        {
            
            var query = from bug in SampleData.AllDefects
                        where bug.Status != Status.Closed
                        where bug.AssignedTo.Name == "Tim Trotter"
                        orderby bug.Severity descending, bug.LastModified
                        select bug;

            foreach (var bug in query)
            {
                Console.WriteLine("{0}: {1} ({2:d})",
                                  bug.Severity, bug.Summary, bug.LastModified);
            }
        }
    }
}
