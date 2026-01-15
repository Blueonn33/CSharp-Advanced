int n = int.Parse(Console.ReadLine());
var elements = new HashSet<string>();
string command = "";

for (int i = 0; i < n; i++)
{
    command = Console.ReadLine();
    string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    foreach (var part in parts)
    {
        elements.Add(part);
    }
}

foreach (var element in elements.OrderBy(e => e))
{
    Console.Write($"{element} ");
}