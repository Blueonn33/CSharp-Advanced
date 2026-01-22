using System.IO;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int counter = 1;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int lettersCount = 0;
                        int punctuationCount = 0; 

                        for (int i = 0; i < line.Length; i++)
                        {
                            if (char.IsLetter(line[i]))
                            {
                                lettersCount++;
                            }
                            else if (char.IsPunctuation(line[i]))
                            {
                                punctuationCount++;
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({lettersCount}) ({punctuationCount})");
                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
