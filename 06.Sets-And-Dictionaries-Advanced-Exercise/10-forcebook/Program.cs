using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

Dictionary<string, HashSet<string>> sides = new();
Dictionary<string, string> users = new();

string input = Console.ReadLine();

while (input != "Lumpawaroo")
{
    bool isCreateCommand = input.Contains("|");
    string[] split = input.Split([" | ", " -> "], StringSplitOptions.RemoveEmptyEntries);

    string side = "";
    string name = "";

    if (isCreateCommand)
    {
        side = split[0];
        name = split[1];
    }
    else
    {
        name = split[0];
        side = split[1];
    }

    if (isCreateCommand)
    {
        if (!users.ContainsKey(name))
        {
            if (!sides.ContainsKey(side))
            {
                sides.Add(side, new HashSet<string>());
            }

            users.Add(name, side);
            sides[side].Add(name);
        }
    }
    else
    {
        if (!sides.ContainsKey(side))
        {
            sides.Add(side, new HashSet<string>());
        }

        if (users.ContainsKey(name))
        {
            string oldSide = users[name];
            sides[oldSide].Remove(name);
            sides[side].Add(name);
            users[name] = side;
        }
        else
        {
            users.Add(name, side);
            sides[side].Add(name);
        }

        Console.WriteLine($"{name} joins the {side} side!");
    }

    input = Console.ReadLine();
}

sides = sides
    .OrderByDescending(s => s.Value.Count)
    .ThenBy(s => s.Key)
    .ToDictionary(s => s.Key, s => s.Value);

foreach (var (side, names) in sides)
{
    if (names.Count == 0)
    {
        continue;
    }

    Console.WriteLine($"Side: {side}, Members: {names.Count}");

    foreach (var name in names.OrderBy(n => n))
    {
        Console.WriteLine($"! {name}");
    }
}