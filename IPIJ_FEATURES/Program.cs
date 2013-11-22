using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_FEATURES
{
    class Program
    {

        static void Main(string[] args)
        {

            LinqExample.Run();
            DelegatesExample.Run();
            AnnonymusTypeExample.Run();
            IteratorExample.Run();
            ExtendMethodExample.Run();
            
            Console.ReadKey();
        }

        
    }
}
