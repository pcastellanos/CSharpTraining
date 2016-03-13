using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShowInfo();
            ShowInfo("LiesAndDamnedLies.java", -10);
            NewCallerMember();
            Console.ReadLine();


        }

        private static void NewCallerMember()
        {
            ShowInfo();
        }

        static void ShowInfo([CallerFilePath] string file = null, [CallerLineNumber] int line = 0, [CallerMemberName] string member = null)
        {
            Console.WriteLine("{0}:{1} - {2}", file, line, member);
        }

    }
}
