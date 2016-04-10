using System;
using System.Threading;

namespace CSharpTraining
{
    class Program
    {
        public static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(15);
            t.Join();
        }

        public static void ThreadMethod(object obj)
        {
            int times = (int)obj;
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

    }
}

