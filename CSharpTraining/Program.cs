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
        static IEnumerable<int> CountWithTimeLimit(DateTime limit)
        {
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (DateTime.Now >= limit)
                    {
                        yield break;
                    }
                    yield return i;
                }
            }
            finally
            {
                Console.WriteLine("Stopping!");
                //Console.ReadLine();
            }
        }

        public static void Main(string[] args)
        {
            DateTime stop = DateTime.Now.AddSeconds(2);
            IEnumerable<int> enumerable = CountWithTimeLimit(stop);
            enumerable.GetEnumerator().MoveNext();
            enumerable.GetEnumerator().Reset();
            foreach (int i in enumerable)
            {
                Console.WriteLine("Received {0}", i);
                Thread.Sleep(300);
            }

            Console.ReadLine();

        }

    }
}
