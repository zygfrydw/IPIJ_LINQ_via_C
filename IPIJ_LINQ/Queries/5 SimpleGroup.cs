using System;
using System.ComponentModel;
using System.Linq;

using ITSILESIA.IPIJ_LINQ.Model;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    static class SimpleGroup
    {
        public static void Run()
        {
            var query = from defect in SampleData.AllDefects
                        where defect.AssignedTo != null
                        group defect.Summary by defect.AssignedTo;

            foreach (var entry in query)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var summary in entry)
                {
                    Console.WriteLine("  {0}", summary);
                }
                Console.WriteLine();
            }
        }
    }
}
