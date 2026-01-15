string input = Console.ReadLine();

Dictionary<char, int> symbolCounts = new Dictionary<char, int>();

char[] symbols = input.ToCharArray();

for (int i = 0; i < symbols.Length; i++)
{
    if (symbolCounts.ContainsKey(symbols[i]))
    {
        symbolCounts[symbols[i]]++;
    }
    else
    {
        symbolCounts[symbols[i]] = 1;
    }
}

foreach (var (symbol, count) in symbolCounts.OrderBy(s => s.Key))
{
    Console.WriteLine($"{symbol}: {count} time/s");
}