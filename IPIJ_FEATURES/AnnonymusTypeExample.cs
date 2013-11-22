using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_FEATURES
{
    static class AnnonymusTypeExample
    {
        public static void Run()
        {

            var number = 10;
            var literal = "Hello world";
            var manager = new System.Threading.HostExecutionContextManager();


            Console.WriteLine("Number: " + number);
            Console.WriteLine("Literal: " + literal);
            
            
            var person = new { Name = "Stanisław", Surname = "Kowalski" };

            Console.WriteLine("My name is {0} and my surname {1}", person.Name, person.Surname);
            Console.WriteLine(person.ToString());
            
        }
    }


    class NullableExample
    {
        void Run()
        {
            Nullable<int> age = 20;
            age = null;

            int? newAge = 22;
            
            if(newAge.HasValue)
            {
                Console.WriteLine("Age: " + newAge);
            }

        }
    }
}
