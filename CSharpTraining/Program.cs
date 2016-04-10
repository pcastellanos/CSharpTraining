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
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine($"{x}");
                }
                
                return "The task was completed";

            }).ContinueWith((resultPreviousExecution) =>{
                //throw new Exception();
                return $"{resultPreviousExecution.Result} after task continue";
                });

            task.ContinueWith((resultPreviousExecution) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            task.ContinueWith((resultPreviousExecution) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = task.ContinueWith((resultPreviousExecution) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            

            //Wait until the task is done is like Thread.Join
            task.Wait();

            Console.WriteLine($"{task.Result}");
            Console.ReadLine();

        }
    }
}


