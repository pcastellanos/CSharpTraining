﻿using System;
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
            MyAggregate aggr = new MyAggregate();

            aggr[0] = "1";
            aggr[1] = "2";
            aggr[2] = "3";
            aggr[3] = "4";
            aggr[4] = "5";
            aggr[5] = "6";
            aggr[6] = "7";
            aggr[7] = "8";
            aggr[8] = "9";
            aggr[9] = "10";

            IIterator iter = aggr.GetIterator();

            for (string s = iter.FirstItem; iter.IsDone == false; s = iter.NextItem)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

    }
}
