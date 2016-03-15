using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    [MemberDescription]
    public class MemberNames
    {
        static MemberNames()
        {
            Log("Static constructor");
        }

        static string foo = Log("Static variable initializer (foo)");

        string bar = Log("Instance variable initializer (bar)");

        public MemberNames()
        {
            Log("Constructor");
        }

        ~MemberNames()
        {
            Log("Finalizer");
            Console.ReadLine();
        }
        static string Log(string message, [CallerMemberName] string member = null)
        {
            Console.WriteLine("{0}: {1}", message, member);
            return null; // Just for the variable initializers
        }
    }
}
