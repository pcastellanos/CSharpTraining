using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            Task<string> task = Task.Run(() =>
            {
                for (int x = 0; x < 10000; x++)
                {
                    Console.WriteLine($"{x}");
                }
                return "The task was completed";

            });
            //Wait until the task is done is like Thread.Join
            task.Wait();

            Console.WriteLine($"{task.Result}"); 
            Console.ReadLine();
           
        }
    }
}


