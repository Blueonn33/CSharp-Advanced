Dictionary<string, string> contestsPasswords = new();
Dictionary<string, Dictionary<string, int>> contestsStudents = new();
Dictionary<string, Dictionary<string, int>> studentContests = new();

string input = Console.ReadLine();

while (input != "end of contests")
{
    string[] split = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

    string contestName = split[0];
    string password = split[1];

    if (!contestsPasswords.ContainsKey(contestName))
    {
        contestsPasswords.Add(contestName, password);
        contestsStudents.Add(contestName, new Dictionary<string, int>());
    }

    input = Console.ReadLine();
}

input = Console.ReadLine();

while (input != "end of submissions")
{
    string[] split = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

    string contestName = split[0];
    string contestPassword = split[1];
    string studentName = split[2];
    int studentScore = int.Parse(split[3]);

    if (contestsPasswords.ContainsKey(contestName) &&
        contestsPasswords[contestName] == contestPassword)
    {
        if (!studentContests.ContainsKey(studentName))
        {
            studentContests.Add(studentName, new Dictionary<string, int>());
        }

        if (!studentContests[studentName].ContainsKey(contestName))
        {
            studentContests[studentName].Add(contestName, 0);
        }

        if (!contestsStudents[contestName].ContainsKey(studentName) ||
            contestsStudents[contestName][studentName] < studentScore)
        {
            contestsStudents[contestName][studentName] = studentScore;
            studentContests[studentName][contestName] = studentScore;
        }
    }

    input = Console.ReadLine();
}

Dictionary<string, int> studentTotalScore = studentContests
    .ToDictionary(s => s.Key, s => s.Value.Values.Sum());

var best = studentTotalScore.OrderByDescending(s => s.Value).First();

Console.WriteLine($"Best candidate is {best.Key} with total {best.Value} points.");
Console.WriteLine("Ranking:");

foreach (var student in studentContests.OrderBy(s => s.Key))
{
    Console.WriteLine(student.Key);

    foreach (var contest in student.Value.OrderByDescending(c => c.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}