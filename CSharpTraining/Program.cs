
using System;
using System.IO;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("DELETE FILE");
           ExampleDeletingFile();
            Console.WriteLine("MOVE FILE");
            ExampleMovingFile();
        }

        private static void ExampleMovingFile()
        {
            string fileName = "test.txt";
            string fileName2 = "test2.txt";
            string path = $@"{Directory.GetCurrentDirectory()}\test";
            string destPath = $@"{Directory.GetCurrentDirectory()}\test\dest";

            if (!Directory.Exists(destPath))
                Directory.CreateDirectory(destPath);

            Console.WriteLine("Using File");
            File.CreateText(Path.Combine(path,fileName)).Close();
            Console.ReadLine();
            File.Copy(Path.Combine(path,fileName), Path.Combine(destPath,fileName));
            Console.ReadLine();

            Console.WriteLine("Using FileInfo");
            FileInfo fileInfo = new FileInfo(Path.Combine(path, fileName2));
            fileInfo.Create().Close();
            Console.ReadLine();
            fileInfo.CopyTo(Path.Combine(destPath, fileName2));
            Console.ReadLine();
        }

        private static void ExampleDeletingFile()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\test.txt";
            File.Create(path).Close();
            Console.ReadLine();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            Console.WriteLine("File deleted using static class: File");
            Console.ReadLine();

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Create().Close();
            Console.ReadLine();

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            Console.WriteLine("File deleted using class: FileInfo");
            Console.ReadLine();
        }
    }
}


