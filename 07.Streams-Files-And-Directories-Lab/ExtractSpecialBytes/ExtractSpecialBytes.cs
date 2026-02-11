using System.Collections.Generic;
using System.Linq;

namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] binaryBytes = File.ReadAllBytes(binaryFilePath);

            var specialBytes = File.ReadAllLines(bytesFilePath)
                .Select(byte.Parse)
                .ToHashSet();

            List<byte> result = new List<byte>();

            foreach (byte b in binaryBytes)
            {
                if (specialBytes.Contains(b))
                {
                    result.Add(b);
                }
            }

            File.WriteAllBytes(outputPath, result.ToArray());
        }
    }
}
