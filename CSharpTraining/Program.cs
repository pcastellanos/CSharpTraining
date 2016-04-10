using System;
using System.Threading;

namespace CSharpTraining
{
    class Program
    {
        public static void Main()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.IsBackground = false;
            thread.Start();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

    }
}

