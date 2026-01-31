int[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int start = input[0];
int end = input[1];
string type = Console.ReadLine();

Predicate<int> filter;

if (type == "odd")
{
    filter = x => x % 2 != 0;
}
else
{
    filter = x => x % 2 == 0;
}

int[] array = Enumerable.Range(start, end - start + 1).ToArray();
array = array.Where(x => filter(x)).ToArray();

Console.WriteLine(string.Join(" ", array));