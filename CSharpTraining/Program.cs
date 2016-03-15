using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static CSharpTraining.Util;
using static System.Console;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => GetWeather());
            ReadKey();
        }

        private async static Task GetWeather()
        {
            HttpClient client = new HttpClient();
            try
            {
                WriteLine("start try");
                var result = await client.GetStringAsync
                ("http://api.openweathermap.org/data/2.5/weather?q=Dhaka,bd");
                WriteLine(result);
            }
            catch (Exception exception)
            {
                try
                {
                    /* If the first request throws an exception, 
                	this request will be executed. 
                        Both are asynchronous request to a weather service*/

                    var result = await client.GetStringAsync
                    ("http://api.openweathermap.org/data/2.5/weather?q=NewYork,us");

                    WriteLine(result);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}

