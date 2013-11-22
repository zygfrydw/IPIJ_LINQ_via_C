﻿using System;
using System.ComponentModel;
using System.Linq;

using ITSILESIA.IPIJ_LINQ.Model;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    static class GroupSelectAndSort
    {
        public static void Run()
        {
            var query = from defect in SampleData.AllDefects
                        where defect.AssignedTo != null
                        group defect by defect.AssignedTo into grouped
                        select new
                        {
                            Assignee = grouped.Key,
                            Count = grouped.Count()
                        } into result
                        orderby result.Count descending
                        select result;

            foreach (var entry in query)
            {
                Console.WriteLine("{0}: {1}",
                                  entry.Assignee.Name,
                                  entry.Count);
            }
        }
    }
}
