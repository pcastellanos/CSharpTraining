using System;
using System.Threading;

namespace CSharpTraining
{
    public static class Program
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>{ return Thread.CurrentThread.ManagedThreadId;});
        public static void Main()
        {
            new Thread(() =>
            {
                Console.WriteLine($"Thread A: _field.Value {_field.Value}");
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            
            new Thread(() =>
            {
                Console.WriteLine($"Thread B: _field.Value {_field.Value}");
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("--------->Thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}


