using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            object[] values = { "a", "b", "c", "d", "e" };
            IterationSample collection = new IterationSample(values, 3);
            //foreach call GetEnumerator -> MoveNext -> Current and finally IDisposable (if it was implemented)
            foreach (object x in collection)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }

    }
}
