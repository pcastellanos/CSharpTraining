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
            Before();
            ReadLine();
            After();
            ReadLine();
        }

        private static void Before()
        {
            Random random = new Random();
            var randomExceptions = random.Next(400, 405);
            WriteLine("Generated exception: " + randomExceptions);
            Write("Exception type: ");

            try
            {
                throw new Exception(randomExceptions.ToString());
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("400"))
                    Write("Bad Request");
                else if (ex.Message.Equals("401"))
                    Write("Unauthorized");
                else if (ex.Message.Equals("402"))
                    Write("Payment Required");
                else if (ex.Message.Equals("403"))
                    Write("Forbidden");
                else if (ex.Message.Equals("404"))
                    Write("Not Found");
            }
        }
        private static void After()
        {
            Random random = new Random();
            var randomExceptions = random.Next(400, 405);
            WriteLine("Generated exception: " + randomExceptions);
            Write("Exception type: ");

            try
            {
                throw new Exception(randomExceptions.ToString());
            }
            catch (Exception ex) when (ex.Message.Equals("400"))
            {
                Write("Bad Request");
            }
            catch (Exception ex) when (ex.Message.Equals("401"))
            {
                Write("Unauthorized");
            }
            catch (Exception ex) when (ex.Message.Equals("402"))
            {
                Write("Payment Required");
            }
            catch (Exception ex) when (ex.Message.Equals("403"))
            {
                Write("Forbidden");
            }
            catch (Exception ex) when (ex.Message.Equals("404"))
            {
                Write("Not Found");
            }
        }
    }
}

