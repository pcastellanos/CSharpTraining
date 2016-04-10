using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            FuncForForEach();
            TestBreakStop();
            Console.WriteLine("Parallel is done");
            Console.ReadLine();
        }

        private static void TestBreakStop()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("STOP loop");
                    loopState.Break();
                }
                return;
            });

            Console.WriteLine($"IsCompleted: {result.IsCompleted}, LowestBreakIteration {result.LowestBreakIteration}");
        }

        private static void FuncForForEach()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"For{i}");
                Thread.Sleep(1000);
            });


            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine($"Foreach{i}");
                Thread.Sleep(1000);
            });
        }
    }
}


