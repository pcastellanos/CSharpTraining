using System;
using System.Collections.Concurrent;
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
            StackMethod();
            Console.ReadLine();
            QueueMethod();
            Console.ReadLine();

        }

        private static void StackMethod()
        {
            Console.WriteLine("StackMethod");
            ConcurrentStack <int> stack = new ConcurrentStack<int>();
            stack.Push(42);
            int result;

            if (stack.TryPop(out result))
                Console.WriteLine($"Popped: {result}");

            stack.PushRange(new int[] { 1, 2, 3 });
            int[] values = new int[2];

            stack.TryPopRange(values);

            foreach (int i in values)
                Console.WriteLine(i);
        }

        private static void QueueMethod()
        {
            Console.WriteLine("QueueMethod");
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);
            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine($"Dequeued: {result}");
        }
    }
}


