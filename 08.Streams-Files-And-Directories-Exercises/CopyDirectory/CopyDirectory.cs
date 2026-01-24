using System.IO;
using System.Text;

namespace CopyDirectory
{
    using System;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            using (FileStream inputStream = new FileStream(inputPath, FileMode.Open))
            {
                using (FileStream outputStream = new FileStream(outputPath, FileMode.OpenOrCreate))
                {
                    int n = 5;
                    byte[] buffer = new byte[n];
                    int readCount = inputStream.Read(buffer, 0, n);

                    while (readCount > 0)
                    {
                        string parsedBuffer = Encoding.ASCII.GetString(buffer);

                        outputStream.Write(buffer, 0, readCount);
                        readCount = inputStream.Read(buffer, 0, n);
                    }
                }
            }
        }
    }
}
