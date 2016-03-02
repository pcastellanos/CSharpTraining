using CSharpTraining.Model;
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
            var query = from defect in SampleData.AllDefects
                        where defect.AssignedTo != null
                        group defect by defect.AssignedTo;

            foreach (var entry in query)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var defect in entry)
                {
                    Console.WriteLine(" ({0}) {1}",
                    defect.Severity, defect.Summary);
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();

            var defects =  SampleData.AllDefects.Where(defect => defect.AssignedTo != null)
                                .GroupBy(defect => defect.AssignedTo, defect => defect);

            foreach (var entry in defects)
            {
                Console.WriteLine(entry.Key.Name);
                foreach (var defect in entry)
                {
                    Console.WriteLine(" ({0}) {1}",
                    defect.Severity, defect.Summary);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
