using System.Collections;

namespace CSharp046.ConceptBehindTuple
{
    class Program
    {
        static void Main()
        {
            // array reference type (list with fixed size) 
            int[] array = { 50, 10, 23, 1, 7, -4 };

            // list represents a dynamically-sized list generally contageous
            List<int> list = new List<int> { 50, 10, 23, 1, 7, -4 };

            list.AddRange(list); // { 50, 10, 23, 1, 7, -4, 50, 10, 23, 1, 7, -4 };



            // collection
            ArrayList al = new ArrayList { "50", 10, 23.2m, DateTime.Now };


            // In .NET Framework new Data Structure is introduced System.Tuple

            Tuple<int, int, int, int, int, int> tuples1 =
                new Tuple<int, int, int, int, int, int>(50, 10, 23, 1, 7, -4);

            Tuple<int, int, int, int, int, int> tuples2 = Tuple.Create(50, 10, 23, 1, 7, -4);

            Tuple<string, decimal> distances = Tuple.Create("hospital", 2.5m);

        }
    }
}