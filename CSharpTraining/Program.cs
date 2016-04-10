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
            TaskWaitAll();
            TaskWaitAny();
            Console.ReadLine();
        }

        private static void TaskWaitAll()
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });
            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("2");
                return 2;
            });
            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            }
            );
            Task.WaitAll(tasks);

            Console.WriteLine("Tasks are done");
        }

        private static void TaskWaitAny()
        {
            //The index of the completed Task object in the tasks array.
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });
            while (tasks.Length > 0)
            {
                int taskDone = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[taskDone];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(taskDone);
                tasks = temp.ToArray();
            }
        }
    }
}


