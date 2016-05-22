
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            WebRequest request = WebRequest.Create("http://www.microsoft.com");
            WebResponse response = request.GetResponse();
            StreamReader responseStream = new StreamReader(response.GetResponseStream());
            
            string responseText = responseStream.ReadToEnd();
            Console.WriteLine(responseText); // Displays the HTML of the website
            response.Close();
            Console.ReadLine();
        }

   
    }
}


