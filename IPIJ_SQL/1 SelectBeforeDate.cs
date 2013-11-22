using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_SQL_2010
{
    //first or default
    public static class SelectBeforeDate
    {
        public static void Run()
        {
            using(var context = new DefectModelDataContext2010DataContext())
            {
                context.Log = Console.Out;

                DateTime date = new DateTime(2013, 5, 10);
                var result = from defects in context.Defects
                             where defects.Created < date
                             select new { defects.Summary, defects.Created };

                foreach(var e in result)
                {
                    Console.WriteLine(e.Created.ToShortDateString() + " " + e.Summary);
                }

            }
        }
    }
}
