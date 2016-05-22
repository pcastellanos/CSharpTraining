
using System;
using System.IO;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Working with DriveInfo");
            ExampleDriveInfo();
            Console.WriteLine("Working with DirectoryInfo or Directory");
            ExampleDirectory();

            Console.WriteLine("Example finding directories with patterns");
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Program Files");
            ListDirectories(directoryInfo, "*a*", 5, 0);
            Console.ReadLine();
        }

        private static void ExampleDirectory()
        {
            var directory = Directory.CreateDirectory(@"C:\ProgrammingInCSharp\Directory");
            var directoryInfo = new DirectoryInfo(@"C:\ProgrammingInCSharp\DirectoryInfo");
            directoryInfo.Create();
            Console.WriteLine("Now delete the files");
            Console.ReadLine();
            if (Directory.Exists(@"C:\ProgrammingInCSharp\Directory"))
            {
                Directory.Delete(@"C:\ProgrammingInCSharp\Directory");
            }

            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }
            Console.ReadLine();

        }

        private static void ExampleDriveInfo()
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drivesInfo)
            {
                Console.WriteLine($"Drive {driveInfo.Name}");
                Console.WriteLine($"File type: {driveInfo.DriveType}");
                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine($"Volume label: {driveInfo.VolumeLabel}");
                    Console.WriteLine($"File system: {driveInfo.DriveFormat}");
                    Console.WriteLine($"Available space to current user:{(driveInfo.AvailableFreeSpace / 1024) / 1024} GB");
                    Console.WriteLine($"Total available space: {(driveInfo.TotalFreeSpace / 1024) / 1024} GB");
                    Console.WriteLine($"Total size of drive: {(driveInfo.TotalSize / 1024) / 1024} GB");
                }
            }
            Console.ReadLine();
        }

        private static void ListDirectories(DirectoryInfo directoryInfo, string searchPattern, int maxLevel, int currentLevel)
        {
            if (currentLevel >= maxLevel)
            {
                return;
            }
            string indent = new string('-', currentLevel);
            try
            {
                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories(searchPattern);
                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    Console.WriteLine(indent + subDirectory.Name);
                    ListDirectories(subDirectory, searchPattern, maxLevel, currentLevel + 1);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // You don’t have access to this folder.
                Console.WriteLine($"{indent} Can't access: {directoryInfo.Name}");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                // The folder is removed while iterating
                Console.WriteLine($"{indent} Can’t find: {directoryInfo.Name}");
                return;
            }
        }
    }
}


