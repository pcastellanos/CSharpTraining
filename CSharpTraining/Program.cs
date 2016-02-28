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
                        join subscription in SampleData.AllSubscriptions
                        on defect.Project equals subscription.Project
                        select new { defect.Summary, subscription.EmailAddress };

            //var query = from subscription in SampleData.AllSubscriptions
            //            join defect in SampleData.AllDefects
            //            on subscription.Project equals defect.Project 
            //            select new { defect.Summary, subscription.EmailAddress };

            //var query = from defect in SampleData.AllDefects
            //            where defect.Status == Status.Closed
            //            join subscription in SampleData.AllSubscriptions
            //            on defect.Project equals subscription.Project
            //            select new { defect.Summary, subscription.EmailAddress };

            //var query = from subscription in SampleData.AllSubscriptions
            //join defect in (from defect in SampleData.AllDefects
            //                where defect.Status == Status.Closed
            //                select defect)
            //on subscription.Project equals defect.Project
            //select new { defect.Summary, subscription.EmailAddress };

            foreach (var entry in query)
            {
                Console.WriteLine("{0}: {1}", entry.EmailAddress, entry.Summary);
            }
            Console.ReadLine();
            
        }       
    }
}
