using System;
using System.Threading;

namespace CSharpTraining
{
    class Program
    {
        public static void Main()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(ThreadMethod));
            thread.Start(15);
            thread.Join();
            Console.WriteLine("The thread stopped");
            Console.ReadLine();
        }

        public static void ThreadMethod(object o)
        {
            bool stopped = false;

            Thread trheadForeground = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            trheadForeground.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            trheadForeground.Join();
            
        }
    }
    

}


