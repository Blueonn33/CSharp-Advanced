Dictionary<int, int> dictionary = new Dictionary<int, int>()
{
    {5,6},
    {3,2},
    {4,3}, {333,4}, {43,4}, {33,4}
};

// 1-ви начин
//Dictionary<int, int> sorted = new(dictionary.OrderBy(item => item.Key));

// 2-ри начин
dictionary = dictionary.OrderByDescending(item => item.Value)
    .ThenByDescending(item => item.Key)
    .ToDictionary(item => item.Key, item => item.Value);

foreach (var (key, value) in dictionary)
{
    Console.WriteLine($"{key} - {value}");
}

Dictionary<string, List<int>> studentScores = new()
{
    {"Martin", [6,6,5]},
    {"Raya", [3,5,6]},
    {"Ema", [3,3,4]}
};

Console.WriteLine();

studentScores = studentScores.OrderByDescending(item => item.Value.Average())
    .ThenByDescending(item => item.Key)
    .ToDictionary(item => item.Key, item => item.Value);

foreach (var (key, value) in studentScores)
{
    Console.WriteLine($"{key} - {value.Average():F2}");
}