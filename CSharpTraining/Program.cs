using System;
using System.Threading;

namespace CSharpTraining
{
    class Program
    {
        public static void Main()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(1000);
            }
            thread.Join();

            Console.WriteLine("Both thread finished");
            Console.ReadLine();

        }
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0},", i);
                Thread.Sleep(300);
            }
        }
    }
}

