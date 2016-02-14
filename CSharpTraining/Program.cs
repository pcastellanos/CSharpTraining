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
        private static IEnumerable<string> ReadLines(string filename)
        {
            using (TextReader reader = File.OpenText(filename))
            {
                try {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        yield return line;
                    }
                }
                finally
                {
                    reader.Close();
                    Console.WriteLine("file closed");
                }
            }
        }

        private static IEnumerable<T> Where<T>(IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null || predicate == null)
            {
                throw new ArgumentNullException();
            }
            return WhereImpl(source, predicate);
        }

        private static IEnumerable<T> WhereImpl<T>(IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static void Main(string[] args)
        {
            IEnumerable<string> lines = ReadLines(@"..\..\TextFile1.txt");
            Predicate<string> predicate = delegate (string line) { return line.StartsWith("using"); };

            foreach (string line in Where(lines, predicate))
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();

        }

    }
}
