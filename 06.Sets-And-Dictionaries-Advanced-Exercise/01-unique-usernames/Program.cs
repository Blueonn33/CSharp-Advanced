int n = int.Parse(Console.ReadLine());
var uniqueNames = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string command = Console.ReadLine();
    uniqueNames.Add(command);
}

foreach (var name in uniqueNames)
{
    Console.WriteLine(name);
}