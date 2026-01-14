int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> studentGrades = new();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (studentGrades.ContainsKey(name))
    {
        studentGrades[name].Add(grade);
    }
    else
    {
        studentGrades.Add(name, new List<decimal> { grade });
    }
}

foreach (var student in studentGrades)
{
    decimal averageGrade = student.Value.Average();

    Console.Write($"{student.Key} -> ");

    foreach (var grade in student.Value)
    {
        Console.Write($"{grade:F2} ");
    }

    Console.Write($"(avg: {averageGrade:F2})");
    Console.WriteLine();
}