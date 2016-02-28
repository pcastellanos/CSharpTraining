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
            ArrayList list = new ArrayList { "First", "Second", "Third", 1 };
            IEnumerable<string> strings = list.Cast<string>();

            var strResult = from str in strings
                            //from string str in list
                            where str.Contains("i")
                            select str;

            foreach (string item in strResult)
            {
                Console.WriteLine(item);
            }

            list = new ArrayList { 1, "not an int", 2, 3, 5, 6, 7, 20 };
            IEnumerable<int> ints = list.OfType<int>();

            var result = from number in ints
                         where number % 2 == 0
                         select number;

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

          
        }



      


    }
}
