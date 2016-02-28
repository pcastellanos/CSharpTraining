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
            var query = from user in SampleData.AllUsers
                        from project in SampleData.AllProjects
                        select new { User = user, Project = project };
            foreach (var pair in query)
            {
                Console.WriteLine("{0}/{1}",
                pair.User.Name,
                pair.Project.Name);
            }

            Console.ReadLine();


            //var list = from left in Enumerable.Range(1, 4)
            //            from right in Enumerable.Range(11, left)
            //            select new { Left = left, Right = right };
            var list = Enumerable.Range(1, 4).SelectMany(left => Enumerable.Range(11, left),
                                                        (left, right) => new { Left = left, Right = right });

            foreach (var pair in list)
            {
                Console.WriteLine("Left={0}; Right={1}",
                pair.Left, pair.Right);
            }
            Console.ReadLine();
        }
    }
}
