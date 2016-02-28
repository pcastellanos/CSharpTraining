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
                        where defect.Status == Status.Closed
                        join subscription in SampleData.AllSubscriptions
                        on defect.Project equals subscription.Project
                        into groupedSubscriptions
                        select new
                        {
                            Defect = defect,
                            Subscriptions = groupedSubscriptions
                        };
            foreach (var entry in query)
            {
                Console.WriteLine(entry.Defect.Summary);
                foreach (var subscription in entry.Subscriptions)
                {
                    Console.WriteLine(" {0}", subscription.EmailAddress);
                }
            }
            Console.ReadLine();

            var dates = new DateTimeRange(SampleData.Start, SampleData.End);
            //var results = from date in dates
            //            join defect in SampleData.AllDefects 
            //            on date equals defect.Created.Date
            //            into defectDates
            //            select new { Date = date, Count = defectDates.Count() };

            var results = dates.GroupJoin(SampleData.AllDefects, 
                                         date => date, 
                                         defect => defect.Created.Date, 
                                         (date, joined) => new { Date = date, Count = joined.Count() });
            foreach (var grouped in results)
            {
                Console.WriteLine("{0:d}: {1}", grouped.Date, grouped.Count);
            }

            Console.ReadLine();

        }       
    }
}
