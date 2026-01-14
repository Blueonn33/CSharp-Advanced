int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continents = new();
string command = "";

for (int i = 0; i < n; i++)
{
    command = Console.ReadLine();
    string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string continent = parts[0];
    string country = parts[1];
    string city = parts[2];

    if (!continents.ContainsKey(continent))
    {
        continents[continent] = new Dictionary<string, List<string>>();
    }
    if (!continents[continent].ContainsKey(country))
    {
        continents[continent][country] = new List<string>();
    }

    continents[continent][country].Add(city);
}

foreach (var (continent, countries) in continents)
{
    Console.WriteLine($"{continent}:");

    foreach (var (country, cities) in countries)
    {
        Console.Write($"{country} -> ");
        Console.WriteLine(string.Join(", ", cities));
    }
}