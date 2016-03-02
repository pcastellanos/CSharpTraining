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
                        group defect by defect.AssignedTo into grouped
                        select new
                        {
                            Assignee = grouped.Key,
                            Count = grouped.Count()
                        } into result
                        orderby result.Count 
                        select result;

            foreach (var entry in query)
            {
                Console.WriteLine("{0}: {1}",
                entry.Assignee.Name,
                entry.Count);
            }

            Console.ReadLine();
            var defects = SampleData.AllDefects.Where(defect => defect.AssignedTo != null)
                                    .GroupBy(defect => defect.AssignedTo)
                                    .Select(grouped => new {Assignee = grouped.Key,Count = grouped.Count()})
                                    .OrderBy(result => result.Count);

            foreach (var entry in defects)
            {
                Console.WriteLine("{0}: {1}",
                entry.Assignee.Name,
                entry.Count);
            }
            Console.ReadLine();

            
        }

  
    }
}
