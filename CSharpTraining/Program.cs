using System;
using System.Threading;

namespace CSharpTraining
{
    class Program
    {
        [ThreadStatic]
        public static int field;
        public static void Main()
        {
            field = 5;
            Console.WriteLine("initial state to Field {0}", field);

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    field++;
                    Console.WriteLine("Thread A: {0}", field);
                    Thread.Sleep(1000);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    field++;
                    Console.WriteLine("---->Thread B: {0}", field);
                    Thread.Sleep(500);
                }
            }).Start();

            Console.ReadLine();
            Console.WriteLine("final state to Field {0}", field);
            Console.ReadLine();
        }
    }


}


