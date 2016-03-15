using System;
using static System.Console;
using static CSharpTraining.Util;
using System.Collections.Generic;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBefore employee = new EmployeeBefore();
            WriteLine($"Name: {employee.Name } Salary:{employee.Salary}");
            ReadKey();
            EmployeeAfter employeeAfter = new EmployeeAfter();
            WriteLine($"Name: {employeeAfter.Name } Salary:{employeeAfter.Salary}");
            ReadKey();
        }
       
    }
    public class EmployeeBefore
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public EmployeeBefore()
        {
            /* Initializing property through constructor */
            Name = "Sammy Jenkins";
            Salary = 10000;
        }
    }

    public class EmployeeAfter
    {
        public string Name { get; set; } = "Sammy Jenkins";
        public decimal Salary { get; set; } = 10000;
      
    }
}

