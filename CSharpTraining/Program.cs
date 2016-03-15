using System;
using System.Collections.Generic;
using static CSharpTraining.Util;
using static System.Console;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //before
            try
            {
                CallSomething();
            }
            catch (Exception exception)
            {
                WriteLine(exception.Message);
            }
            ReadLine();
            //After
            try
            {
                CallSomethingNew();
            }
            catch (Exception exception)
            {
                WriteLine(exception.Message);
            }

            ReadLine();
        }
        //before
        private static void CallSomething()
        {
            int? number = null;

            if (number == null) 
            {
                //x is the type name. What if someone changes the type name from x to i ? The exception below would be inappropriate.
                throw new Exception("x is null");
            }
        }

        //after
        private static void CallSomethingNew()
        {
            int? number = null;

            if (number == null)
            {
                throw new Exception($"{nameof(number)} is null");
            }
        }

    }
}

