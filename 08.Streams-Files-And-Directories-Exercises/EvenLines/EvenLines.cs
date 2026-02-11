namespace EvenLines
{
    using System;
    using System.IO;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            int counter = 0;
            string result = "";

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] lineArr = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Array.Reverse(lineArr);
                    char[] symbols = new char[] { '-', ',', '.', '!', '?' };

                    for (int i = 0; i < lineArr.Length; i++)
                    {
                        for (int j = 0; j < symbols.Length; j++)
                        {
                            lineArr[i] = lineArr[i].Replace(symbols[j].ToString(), "@");
                        }
                    }

                    if (counter % 2 == 0)
                    {
                        result += string.Join(" ", lineArr) + Environment.NewLine;
                    }

                    line = reader.ReadLine();
                    counter++;
                }
            }

            return result;
        }
    }
}
