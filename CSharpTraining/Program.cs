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
            var query = from defect in SampleData.AllDefects
                        where defect.Status != Status.Closed
                        where defect.AssignedTo == tim
                        orderby defect.Severity descending, defect.LastModified //ascending
                        select defect;
            foreach (var defect in query)
            {
                Console.WriteLine("{0}: {1} {2}", defect.Severity, defect.Summary, defect.LastModified.ToShortDateString());
            }
            
            Console.ReadLine();

            //translated
            var defects = SampleData.AllDefects.Where(defect => defect.Status != Status.Closed)
                                 .Where(defect => defect.AssignedTo == tim)
                                 .OrderByDescending(defect => defect.Severity)
                                 .ThenBy(defect => defect.LastModified);
            foreach (var defect in defects)
            {
                Console.WriteLine("{0}: {1} {2}", defect.Severity, defect.Summary, defect.LastModified.ToShortDateString());
            }
            Console.ReadLine();
        }       
    }
}
