using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            string result = DownloadContent().Result;

            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                Task<string> taskResult =  client.GetStringAsync("http://www.microsoft.com");
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"{i}");
                }
                string result = await taskResult;
                
                return result;
            }
        }
    }
}


