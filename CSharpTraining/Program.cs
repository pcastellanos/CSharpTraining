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
            User tim = SampleData.Users.TesterTim;
            var results = from defect in SampleData.AllDefects
                        where defect.Status != Status.Closed
                        where defect.AssignedTo == tim
                        select defect.Summary;
            foreach (var summary in results)
            {
                Console.WriteLine(summary);
            }
            Console.ReadLine();
            //The query expression is translated into this
            IEnumerable<string> summaries = SampleData.AllDefects.Where(defect => defect.Status != Status.Closed)
                                                                 .Where(defect => defect.AssignedTo == tim)
                                                                 .Select(defect => defect.Summary);
            foreach (var summary in summaries)
            {
                Console.WriteLine(summary);
            }
            Console.ReadLine();


        }



      


    }
}
