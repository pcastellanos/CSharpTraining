using ProjectB;
using System;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {

            Worker worker = new Worker(26, "calle 72", "Paula", "Castellanos");
            Console.WriteLine(worker.Information());
            Console.ReadLine();

            Student student = new Student(26, "calle 72", "Alejandra", "Medina");
            Console.WriteLine(student.Information());
            Console.ReadLine();

        }

    }
}


