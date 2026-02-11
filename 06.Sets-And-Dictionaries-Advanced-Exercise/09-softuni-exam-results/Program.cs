// "{username}-{language}-{points}", until "exam finished". 

string command = Console.ReadLine();

Dictionary<string, int> languageCounts = new();
Dictionary<string, int> userPoints = new();

while (command != "exam finished")
{
    string[] inputParts = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
    string username = inputParts[0];
    string language = inputParts[1];
    int points = 0;

    if (language == "banned")
    {
        userPoints.Remove(username);
    }
    else
    {
        points = int.Parse(inputParts[2]);

        if (!languageCounts.ContainsKey(language) && language != "banned")
        {
            languageCounts[language] = 0;
        }

        if (!userPoints.ContainsKey(username))
        {
            userPoints[username] = points;
        }
        else
        {
            if (userPoints[username] < points)
            {
                userPoints[username] = points;
            }
        }

        languageCounts[language]++;
    }

    command = Console.ReadLine();
}

languageCounts = languageCounts.OrderByDescending(s => s.Value).ThenBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
 userPoints = userPoints.OrderByDescending(s => s.Value).ThenBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

Console.WriteLine("Results:");

foreach (var (name, points) in userPoints.Where(u => u.Value > 0))
{
    Console.WriteLine($"{name} | {points}");
}

Console.WriteLine($"Submissions:");

foreach (var (language, count) in languageCounts)
{
    Console.WriteLine($"{language} - {count}");
}