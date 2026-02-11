namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            string[] files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

            long totalBytes = 0;

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                totalBytes += info.Length;
            }

            double sizeInKb = totalBytes / 1024.0;

            File.WriteAllText(outputFilePath, $"{sizeInKb} KB");
        }

    }
}
