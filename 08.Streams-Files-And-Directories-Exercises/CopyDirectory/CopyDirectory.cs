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
            string[] filePaths = Directory.GetFiles(inputPath);

            foreach (var filePath in filePaths)
            {
                FileInfo fileInfo = new FileInfo(filePath);

                if (fileInfo == null)
                {
                    continue;
                }

                Console.WriteLine(fileInfo.FullName);
                Console.WriteLine(fileInfo.Extension);

                string newFilePath = $"{outputPath}/{fileInfo.Name}";

                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                }

                File.Copy(filePath, outputPath);
            }
        }
    }
}
