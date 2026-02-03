int n = int.Parse(Console.ReadLine());
int[] array = Enumerable.Range(1, n).ToArray();
int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

List<Func<int, bool>> filters = new();

foreach (int divisor in divisors)
{
    Func<int, bool> filter = n =>
    {
        return n % divisor == 0;
    };

    filters.Add(filter);
}

foreach (var filter in filters)
{
    List<int> filteredList = new();

    foreach (var number in array)
    {
        if (filter(number))
        {
            filteredList.Add(number);
        }
    }

    array = filteredList.ToArray();
}

Console.WriteLine(string.Join(" ", array));