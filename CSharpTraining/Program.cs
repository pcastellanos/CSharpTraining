using System;
using static System.Console;
using static CSharpTraining.Util;
using System.Collections.Generic;

namespace CSharpTraining
{
    class Program
    {
        static void Main()
        {
            //before
            Dictionary<string, string> alien = new Dictionary<string, string>()
            {
                { "Name", "Fizzy"},
                { "Planet", "Kepler-452b"}
            };
            PrintDict(alien);

            ReadLine();

            //C#6
            alien = new Dictionary<string, string>()
            {
                ["Name"] = "Fizzy",
                ["Planet"] = "Kepler-452b"
            };

            PrintDict(alien);

            ReadLine();
        }

        private static void PrintDict(Dictionary<string, string> alien)
        {
            foreach (KeyValuePair<string, string> keyValuePair in alien)
            {
                WriteLine($"{keyValuePair.Key}:{keyValuePair.Value}");
            }
        }
    }
}
