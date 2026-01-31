Action<string[]> printer = PrintNames;

string[] input = Console.ReadLine().Split();
printer(input);

void PrintNames(string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}