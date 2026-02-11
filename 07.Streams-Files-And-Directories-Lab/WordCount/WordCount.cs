namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using var words = new StreamReader(wordsFilePath);
            using var reader = new StreamReader(textFilePath);
            using var writer = new StreamWriter(outputFilePath);

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            while (true)
            {
                var line = words.ReadLine();

                if (line == null)
                {
                    break;
                }

                string[] wordsInput = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in wordsInput)
                {
                    string lower = word.ToLower();

                    if (!wordCounts.ContainsKey(lower))
                    {
                        wordCounts[lower] = 0;
                    }
                }
            }

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                string[] wordsInput = line.Split(
                    new char[] { ',', ' ', '.', '?', '!', '-' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in wordsInput)
                {
                    string lower = word.ToLower();

                    if (wordCounts.ContainsKey(lower))
                    {
                        wordCounts[lower]++;
                    }
                }
            }

            foreach (var (word, count) in wordCounts.OrderByDescending(c => c.Value))
            {
                writer.WriteLine($"{word} - {count}");
            }
        }
    }
}
