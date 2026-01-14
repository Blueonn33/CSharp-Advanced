// (string) name , (string) phoneNumber
Dictionary<string, string> phoneNumbers = new();

// name (string), scores (double)
Dictionary<string, double> scores = new();

scores["Martin"] = 6;
scores["Alex"] = 4.5;
scores["John"] = 3.5;
scores["Mary"] = 5.5;
scores["Steve"] = 4.5;

foreach (var (name, score) in scores)
{
    Console.WriteLine($"{name} has a score of {score}");
}

//foreach (var entry in scores)
//{
//    var name = entry.Key;
//    var score = entry.Value;

//    Console.WriteLine($"{name} has a score of {score}");
//}

SortedDictionary<string, double> sortedScores = new(scores);

Console.WriteLine();
Console.WriteLine();

sortedScores.Add("Emiliqna", 3.4);
sortedScores.Remove("John");
sortedScores.Remove("Mary");
sortedScores.Remove("Steve");

foreach (var (name, score) in sortedScores)
{
    Console.WriteLine($"{name} has a score of {score}");
}