Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .Select(price => price + price * 20 / 100)
    .Select(n => $"{n:F2}")
    .ToList()
    .ForEach(n => Console.WriteLine(n));