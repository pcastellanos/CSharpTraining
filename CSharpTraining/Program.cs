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
    static class Extensions
    {
        public static Dummy<T> Where<T>(this Dummy<T> dummy,
                                        Func<T, bool> predicate)
        {
            Console.WriteLine("Where called");
            return dummy;
        }
    }

    class Dummy<T>
    {
        public Dummy<U> Select<U>(Func<T, U> selector)
        {
            Console.WriteLine("Select called");
            return new Dummy<U>();
        }
    }

    class Program
    {
        
        public static void Main(string[] args)
        {
            var query = from user in SampleData.AllUsers
                        select user;
            foreach (var user in query)
            {
                Console.WriteLine(user);
            }
            Console.ReadLine();

            //var source = new Dummy<string>();

            //var result = from dummy in source
            //            where dummy.ToString() == "Ignored"
            //            select "Anything";

            //Console.ReadLine();

        }



      


    }
}
