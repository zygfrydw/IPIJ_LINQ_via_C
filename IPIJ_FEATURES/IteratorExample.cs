using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSILESIA.IPIJ_FEATURES
{

    class OldAlphabet : IEnumerable<char>
    {
        #region RangeStaff
        char[] Table = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        #endregion

        public class RangeIterator : IEnumerator<char>
        {
            OldAlphabet parent;
            int actual;

            public RangeIterator(OldAlphabet parent)
            {
                this.parent = parent;
                actual = -1;
            }

            public char Current
            {
                get { return parent.Table[actual]; }
            }

            public void Dispose()
            {
                
            }

            object System.Collections.IEnumerator.Current
            {
                get { return this.Current; }
            }

            public bool MoveNext()
            {
                actual++;
                return actual < parent.Table.Length;

            }

            public void Reset()
            {
                actual = -1;
            }
        }

        public IEnumerator<char> GetEnumerator()
        {
            return new RangeIterator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class ShortIterator : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            yield return 20;
            yield return 30;
            yield return 40;
            yield return 50;
            yield return 60;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class NewAlphabet : IEnumerable<char>
    {
        char[] Table = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < Table.Length; i++)
                yield return Table[i];
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    
    
    static class IteratorExample
    {
        public static void Run()
        {
            OldAlphabet oldAlphabet = new OldAlphabet();

            foreach(var letter in oldAlphabet)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("------ New alphabet --------");

            NewAlphabet newAlphabet = new NewAlphabet();
            foreach(var letter in newAlphabet)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
