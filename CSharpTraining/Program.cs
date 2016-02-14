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
            object[] values = { "a", "b", "c"};
            IterationSample collection = new IterationSample(values, 0);
            IEnumerator
                iterator = collection.GetEnumerator();
            Console.WriteLine("Starting to iterate");
            Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Calling MoveNext()...");
                bool result = iterator.MoveNext();
                Console.WriteLine("... MoveNext result={0}", result);
                Console.ReadLine();
                if (!result)
                {
                    break;
                }
                Console.WriteLine("Fetching Current...");
                Console.WriteLine("... Current result={0}", iterator.Current);
                Console.ReadLine();
            }

            Console.ReadLine();

        }

    }
}
