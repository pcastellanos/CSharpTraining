using System;

namespace CSharpTraining
{
    class MoveableOject : ILeft, IRight
    {
        void ILeft.Move() {
            Console.WriteLine("ILeft");

        }
        void IRight.Move() {
            Console.WriteLine("IRight");
        }
    }
}

