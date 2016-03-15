using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static CSharpTraining.Util;
using static System.Console;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            WriteLine("I'm " + person.FullName);
            WriteLine(person.BuySomething(100));
            WriteLine(Person.AddNumber(2,3));
            ReadLine();
        }
        
    }
    public class Person
    {
        public string FirstName { get; } = "Fiyaz";
        public string LastName { get; } = "Hasan";

        public int Salary { get; private set; } = 3000000;
        /* Expression bodied function */
        public int BuySomething(int price) => Salary -= price;
        public static int AddNumber(int x, int y) => x + y;
        
        /* Expression bodied computed property */
        public string FullName => $"{FirstName} {LastName}";
    }
}

