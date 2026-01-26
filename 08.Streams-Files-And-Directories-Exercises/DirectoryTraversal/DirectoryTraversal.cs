using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<FileInfo>> extensions = new();

            string[] filePaths = Directory.GetFiles(inputFolderPath);

            foreach (var filePath in filePaths)
            {
                FileInfo fileInfo = new FileInfo(filePath);

                if (!extensions.ContainsKey(fileInfo.Extension))
                {
                    extensions.Add(fileInfo.Extension, new List<FileInfo>());
                }

                extensions[fileInfo.Extension].Add(fileInfo);
            }

            extensions = extensions.OrderByDescending(e => e.Value.Count)
                .ThenBy(e => e.Key)
                                      .ToDictionary(e => e.Key, e => e.Value);

            StringBuilder result = new();

            foreach (var (extension, fileInfos) in extensions)
            {
                result.AppendLine($"{extension}");

                foreach (var fileInfo in fileInfos.OrderByDescending(f => f.Length))
                {
                    result.AppendLine($"--{fileInfo.Name} - {Math.Ceiling(fileInfo.Length / 1024.0)}kb");
                }
            }

            return result.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            using (StreamWriter writer = new StreamWriter(reportFileName))
            {
                writer.WriteLine(textContent);
            }
        }
    }
}
