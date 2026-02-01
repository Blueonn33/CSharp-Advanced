int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split()
    .ToArray();

Func<string, int, bool> lengthFilter = (s, n) => s.Length <= n;

string[] filteredNames = names.Where(name => lengthFilter(name, n))
    .ToArray();

Console.WriteLine(string.Join(Environment.NewLine, filteredNames));