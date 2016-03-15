using System;
using static System.Console;
using static CSharpTraining.Util; 

namespace CSharpTraining
{
    class Program
    {
        static void Main()
        {
            string name = "Sammy Jenkins";
            double salary = 1000;

            WriteLine($"{name}'s monthly salary is {salary:C2}");
            WriteLine($"Man! This {name} is kind of a { (salary >= 1000 ? "rich guy" : "poor guy")}");
            WriteLine($"Using methods {Test()}");
            ReadLine();
        }
        
    }
}
