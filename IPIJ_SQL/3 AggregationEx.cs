using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_SQL_2010
{
    //Avarange!!
    static class AggregationEx
    {
        public static void Run()
        {
            using(var context = new DefectModelDataContext2010DataContext())
            {
                context.Log = Console.Out;

                var userAndCount = from user in context.Users
                           join defect in context.Defects on user.UserID equals defect.AssignedToUserID
                           into grouped
                           select new { Name = user.Name, Defects = grouped.Count()};
                
               foreach(var u in userAndCount)
               {
                   Console.WriteLine(u.Name + " defects: " + u.Defects);
               }
            }
        }
    }
}
