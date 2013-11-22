using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITSILESIA.IPIJ_LINQ.Model;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    static class FirstOff
    {
        public static void Run()
        {
            var users = SampleData.AllUsers.Where(us => us.UserType == UserType.Developer).
                                           OrderBy(us => us.Name);

            foreach(var user in users)
            {
                Console.WriteLine("User name: {0} user type: {1}", user.Name, user.UserType);
            }
        }
    }
}
