using System;
using ITSILESIA.IPIJ_LINQ.Queries;

namespace ITSILESIA.IPIJ_LINQ.ItSilesia
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstOff.Run();
            WhereWhereOrder.Run();
            SimpleJoin.Run();
            LetOrder.Run();
            SimpleGroup.Run();
            GroupWithProjection.Run();
            GroupSelectAndSort.Run();
            DisplayListingsMap.Run();
            Console.ReadKey();
        }
    }
}
