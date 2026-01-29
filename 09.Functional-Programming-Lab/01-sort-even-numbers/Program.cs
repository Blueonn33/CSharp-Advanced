var numbers = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .Where(n => n % 2 == 0)
    .OrderBy(n => n);

Console.WriteLine(string.Join(", ", numbers));