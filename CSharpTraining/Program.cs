using System;
using static System.Console;
using static CSharpTraining.Util; 

namespace CSharpTraining
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("with Console");
            Console.ReadLine();

            WriteLine("without Console");
            WriteLine(Test());
            ReadLine();
        }
        
    }
}
