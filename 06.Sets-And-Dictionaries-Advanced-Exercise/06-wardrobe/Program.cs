int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> colorItems = new();

for (int i = 0; i < n; i++)
{
    string[] splittedInput = Console.ReadLine()
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    string[] items = splittedInput[1]
        .Split(',', StringSplitOptions.RemoveEmptyEntries);

    if (!colorItems.ContainsKey(splittedInput[0]))
    {
        colorItems.Add(splittedInput[0], new Dictionary<string, int>());
    }

    foreach (var item in items)
    {
        if (!colorItems[splittedInput[0]].ContainsKey(item))
        {
            colorItems[splittedInput[0]].Add(item, 0);
        }
        colorItems[splittedInput[0]][item]++;
    }
}

string[] searchedItem = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

string searchedColor = searchedItem[0];
string searchedClothing = searchedItem[1];

foreach (var (color, item) in colorItems)
{
    Console.WriteLine($"{color} clothes:");

    foreach (var (itemName, count) in item)
    {
        if (searchedColor == color && searchedClothing == itemName)
        {
            Console.WriteLine($"* {itemName} - {count} (found!)");
        }
        else
        {
            Console.WriteLine($"* {itemName} - {count}");
        }
    }
}