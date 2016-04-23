
using System;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {

            MoveableOject obj = new MoveableOject();
            ((ILeft)obj).Move();
            ((IRight)obj).Move();
            Console.ReadLine();

        }

    }
}


