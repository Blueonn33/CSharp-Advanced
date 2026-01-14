var shops = new SortedDictionary<string, Dictionary<string, double>>();

while (true)
{
    var command = Console.ReadLine();

    if (command == "Revision")
    {
        break;
    }

    var commandParts = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    var shop = commandParts[0];
    var product = commandParts[1];
    var price = double.Parse(commandParts[2]);

    if (!shops.ContainsKey(shop))
    {
        shops[shop] = new Dictionary<string, double>();
    }

    shops[shop][product] = price;
}

foreach (var (shop, products) in shops)
{
    Console.WriteLine($"{shop}->");

    foreach (var (product, price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}