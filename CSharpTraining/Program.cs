
using System;
using System.IO;
using System.Text;

namespace CSharpTraining
{
    public static class Program
    {
        private static string path = $@"{Directory.GetCurrentDirectory()}\test.txt";
        public static void Main()
        {
           WrittingFile();
           Console.WriteLine("Writting file is done");
           Console.ReadLine();
           ReadingFile();
        }

        private static void ReadingFile()
        {
            
            Console.WriteLine("Reading with FileStream");
            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];
                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();
                }
                Console.WriteLine(Encoding.UTF8.GetString(data)); // Displays: MyValue
            }

            Console.ReadLine();
            Console.WriteLine("Reading with StreamReader");
            using (StreamReader streamWriter = File.OpenText(path))
            {
                Console.WriteLine(streamWriter.ReadLine()); // Displays: MyValue
            }
            Console.ReadLine();
        }

        private static void WrittingFile()
        {
            Console.WriteLine("Working with FileStream");
            using (FileStream fileStream = File.Create(path))
            {
                string myValue = "MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                fileStream.Write(data, 0, data.Length);
            }
            Console.ReadLine();

            Console.WriteLine("Working with StreamWriter");
            File.Delete(path);
            using (StreamWriter streamWriter = File.CreateText(path))
            {
                string myValue = "MyValue";
                
                streamWriter.Write(myValue);
            }
            Console.ReadLine();
        }
    }
}


