int n = int.Parse(Console.ReadLine());
Dictionary<int, int> counts = new Dictionary<int, int>();
int number = 0;

for (int i = 0; i < n; i++)
{
    int commandInput = int.Parse(Console.ReadLine());

    if (counts.ContainsKey(commandInput))
    {
        counts[commandInput]++;

        if (counts[commandInput] % 2 == 0)
        {
            number = commandInput;
        }
    }
    else
    {
        counts[commandInput] = 1;
    }
}

Console.WriteLine(number);