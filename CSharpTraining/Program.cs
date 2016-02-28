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
                        orderby user.Name.Length
                        select user.Name;
            foreach (var name in query)
            {
                Console.WriteLine("{0}: {1}", name.Length, name);
            }
            Console.ReadLine();

            //Console.WriteLine("Using let");
            //var users = from user in SampleData.AllUsers
            //            let length = user.Name.Length
            //            orderby length
            //            select new { Name = user.Name, Length = length };

            //foreach (var user in users)
            //{
            //    Console.WriteLine("{0}: {1}", user.Length, user.Name);
            //}
            //Console.ReadLine();

            //translated
            //var resultUsers = SampleData.AllUsers.Select(user => new { user, length = user.Name.Length })
            //        .OrderBy(user => user.length)
            //        .Select(anonymousUser => new { Name = anonymousUser.user.Name, Length = anonymousUser.length });

            //foreach (var user in resultUsers)
            //{
            //    Console.WriteLine("{0}: {1}", user.Length, user.Name);
            //}
            //Console.ReadLine();
        }       
    }
}
