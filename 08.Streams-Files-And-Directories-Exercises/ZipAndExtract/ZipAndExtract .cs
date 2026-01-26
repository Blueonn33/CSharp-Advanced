using System.IO.Compression;

namespace ZipAndExtract
{
    using System;
    using System.IO;
    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (ZipArchive zipFile = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Update))
            {
                zipFile.CreateEntryFromFile(inputFilePath, Path.GetFileName(inputFilePath));
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using (ZipArchive zipFile = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in zipFile.Entries)
                {
                    if (entry.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase))
                    {
                        entry.ExtractToFile(outputFilePath, true);
                        break;
                    }
                }
            }
        }
    }
}
