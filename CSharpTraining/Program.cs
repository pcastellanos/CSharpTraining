
using System;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {

            Base b = new Base();
            b.Execute();
            Base b1 = new Derived();
            b1.Execute();
            Console.ReadLine();

            Derived b2 = new Derived();
            b2.Method();
            Console.ReadLine();
        }

    }

    class Base
    {
        public void Execute() { Console.WriteLine("Base.Execute"); }
    }
    class Derived : Base
    {
     
        public void Method()
        {
            this.Execute();
        }
        public new void Execute()
        {
            Console.WriteLine("Derived.Execute");
        }
    }

}


