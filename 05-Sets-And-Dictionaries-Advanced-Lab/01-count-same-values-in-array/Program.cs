double[] array = Console.ReadLine().
    Split(' ').Select(double.Parse).ToArray();

Dictionary<double, int> counts = new();

foreach (var number in array)
{
    if (counts.ContainsKey(number))
    {
        counts[number]++;
    }
    else
    {
        counts.Add(number, 1);
    }
}

foreach (var (number, count) in counts)
{
    Console.WriteLine($"{number} - {count} times");
}