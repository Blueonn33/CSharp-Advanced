var numbers = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToList();

Console.WriteLine(numbers.Count);
Console.WriteLine(numbers.Sum());
