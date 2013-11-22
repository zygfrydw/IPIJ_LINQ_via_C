using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_FEATURES
{
    static class CollectionUtils
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach(var item in source)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }

    static class ExtendMethodExample
    {
        static public void Run()
        {
            List<Person> people = DataFactory.GetSamplePeople();

            foreach(var person in people.Where(x => x.Age > 70))
            {
                Console.WriteLine(person);
            }

        }

    }
}
