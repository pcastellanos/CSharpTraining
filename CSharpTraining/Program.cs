
using System;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {

            Base b = new Derived();
            b.MethodWithImplementation();
            b.AbstractMethod();
            Console.ReadLine();
        }

    }

    abstract class Base
    {
        public virtual void MethodWithImplementation()
        {
            Console.WriteLine("MethodWithImplementation");
        }
        public abstract void AbstractMethod();
    }
    sealed class Derived : Base
    {
        public override void MethodWithImplementation()
        {
            Console.WriteLine("MethodWithImplementation Derived ");
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("AbstractMethod");
        }
    }

    //class Derived2 : Derived
    //{

    //}

}


