using System;
using System.Linq;

using ITSILESIA.IPIJ_LINQ.Model;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    static class VeryComplexGroup
    {
        public static void Run()
        {
            var query = from project in SampleData.AllProjects
                        join defect in SampleData.AllDefects on project equals defect.Project into joined
                        select new { Project = project, DefectsBySeverity =                                                     
                            (from defect in joined where defect.Status != Status.Closed group defect by defect.Severity 
                                 into grouped orderby grouped.Key descending select new { Severity = grouped.Key, Count = grouped.Count() }) };

            foreach (var entry in query)
            {
                Console.WriteLine(entry.Project.Name);
                foreach (var subEntry in entry.DefectsBySeverity)
                {
                    Console.WriteLine("  {0}={1}", subEntry.Severity, subEntry.Count);
                }
                Console.WriteLine();
            }
        }
    }
}
