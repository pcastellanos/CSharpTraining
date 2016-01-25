using Entities;
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

            ExampleAsync();
        }

        private static async void ExampleAsync()
        {
            Task demoWait = DoStuff();

            for (int i=0; i<500; i++)
            {
                Console.WriteLine("Doing Stuff on the Main Thread "+i);
            }

            //await demoWait;
            //Console.WriteLine("afsfafsdfsfsfkfsnfksnfkwnfwfnwenefmipedfikp");
            Console.ReadLine();
        }


        private static async Task DoStuff()
        {
            await Task.Run(() =>
            {
                for (int counter = 0; counter < 1000; counter++)
                {
                    Console.WriteLine(counter);
                }
            });
        }
    }
}
