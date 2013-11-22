using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITSILESIA.IPIJ_LINQ.Model;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    static class SimpleJoin
    {
        public static void Run()
        {

            var query = from user in SampleData.AllUsers
                            join defect in SampleData.AllDefects on user equals defect.AssignedTo into defects
                            select new { User = user, Defects = defects };


                foreach (var user in query)
                {
                    Console.WriteLine("{0} --------------------------", user.User.Name);
                    foreach(var bug in user.Defects)
                    {
                        Console.WriteLine("\t" + bug.Summary);
                    }
                }
            }
    }
}
