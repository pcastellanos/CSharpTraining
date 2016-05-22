
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace CSharpTraining
{
    public static class Program
    {
        public static void Main()
        {
            UsingGZipStream();
            Console.ReadLine();
            UsingBufferedStream();
            Console.ReadLine();
        }

        private static void UsingBufferedStream()
        {
            string path  = Path.Combine(Directory.GetCurrentDirectory(), "bufferedStream.txt");
            using (FileStream fileStream = File.Create(path))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamWriter streamWriter = new StreamWriter(bufferedStream))
                    {
                        streamWriter.WriteLine("A line of text.");
                    }
                }
            }
            Console.WriteLine("end of buffered example");
        }

        private static void UsingGZipStream()
        {
            string folder = Directory.GetCurrentDirectory();
            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.gz");
            byte[] dataToCompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();
            using (FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
            {
                uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
            }

            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    compressionStream.Write(dataToCompress, 0, dataToCompress.Length);
                }
            }

            FileInfo uncompressedFile = new FileInfo(uncompressedFilePath);
            FileInfo compressedFile = new FileInfo(compressedFilePath);
            Console.WriteLine(uncompressedFile.Length); // Displays 1048576
            Console.WriteLine(compressedFile.Length); // Displays 1052
        }
    }
}


