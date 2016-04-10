using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            Parallel();
            Console.ReadLine();
            TestForAll();
            Console.ReadLine();
            ParallelWithException();
            Console.ReadLine();
        }

        private static void Parallel()
        {
            DateTime initialTime;

            initialTime = DateTime.Now;
            var numbers = Enumerable.Range(0, 10);

            Console.WriteLine("Parallel");
            //Console.WriteLine("Parallel with ordered");
            //var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();
            Console.WriteLine(DateTime.Now - initialTime);

            foreach (int i in parallelResult)
            {
                Console.WriteLine(i);

            }
        }
        private static void TestForAll()
        {
            //ForAll does not need all results before it starts executing. In this example, ForAll does, however, remove any sort order that is specified
            Console.WriteLine("Parallel for all");
            var numbers2 = Enumerable.Range(0, 20);
            var parallelResult2 = numbers2.AsParallel().Where(i => i % 2 == 0);
            parallelResult2.ForAll(e => Console.WriteLine(e));
        }

        private static void ParallelWithException()
        {
            Console.WriteLine("Parallel With Exception");
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"There where {e.InnerExceptions.Count} exceptions");
            }
        }

        private static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}


