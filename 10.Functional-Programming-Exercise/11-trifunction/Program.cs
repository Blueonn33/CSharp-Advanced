int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split();

foreach (var name in names)
{
    if (AreCharactersBigger(name, n))
    {
        Console.WriteLine(name);
        return;
    }
}

bool AreCharactersBigger(string input, int n)
{
    int characters = 0;

    for (int i = 0; i < input.Length; i++)
    {
        characters += input[i];
    }

    return characters > n;
}