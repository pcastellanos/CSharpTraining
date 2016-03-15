using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpTraining
{
    class Program
    {
        static void Main()
        {
            var instance = new MemberNames();
            var instance2 = new MemberNames();
            Console.ReadLine();

            dynamic x = new TypeUsedDynamically();
            x.ShowCaller();
            Console.ReadLine();

            var attribute = (MemberDescriptionAttribute)typeof(MemberNames).GetCustomAttributes(typeof(MemberDescriptionAttribute), false)[0];
            Console.WriteLine("Attribute on type: {0} total: {1}", attribute.Member);
            Console.ReadLine();
        }
        
        class TypeUsedDynamically
        {
            internal void ShowCaller([CallerMemberName] string caller = "Unknown")
            {
                Console.WriteLine("Called by: {0}", caller);
            }
        }
    }
}
