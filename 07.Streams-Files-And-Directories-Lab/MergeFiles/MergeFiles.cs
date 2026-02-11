namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using var firstInput = new StreamReader(firstInputFilePath);
            using var secondInput = new StreamReader(secondInputFilePath);
            using var writer = new StreamWriter(outputFilePath);

            while (true)
            {
                var line1 = firstInput.ReadLine();
                var line2 = secondInput.ReadLine();

                if (line1 != null)
                {
                    writer.WriteLine(line1);
                }

                if (line2 != null)
                {
                    writer.WriteLine(line2);
                }

                if (line1 == null && line2 == null)
                {
                    break;
                }
            }
        }
    }
}
