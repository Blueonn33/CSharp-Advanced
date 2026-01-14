int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] sorted = numbers.OrderByDescending(n => n).ToArray();

if (sorted.Length >= 3)
{
    Console.WriteLine($"{sorted[0]} {sorted[1]} {sorted[2]}");
}
else
{
    foreach (var item in sorted)
    {
        Console.Write($"{item} ");
    }
}