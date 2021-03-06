﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_SQL_2010
{
    static class JoinAndGroup
    {
        public static void Run()
        {
            using (var context = new DefectModelDataContext2010DataContext())
            {
                context.Log = Console.Out;

                var result = from user in context.Users
                             join defect in context.Defects on user.UserID equals defect.CreatedByUserID into def
                             select new { Name = user.Name, Defects = def };

                foreach (var u in result)
                {
                    Console.WriteLine("------ " + u.Name + " -----");

                    foreach (var val in u.Defects)
                    {
                        Console.WriteLine("\t" + val.Summary);
                    }
                }
            }
        }
    }
}
