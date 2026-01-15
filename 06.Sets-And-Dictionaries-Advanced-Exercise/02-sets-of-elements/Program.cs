int[] numberOfSets = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var firstSet = new HashSet<int>();
var secondSet = new HashSet<int>();

for (int i = 0; i < numberOfSets[0]; i++)
{
    int number = int.Parse(Console.ReadLine());
    firstSet.Add(number);
}

for (int i = 0; i < numberOfSets[1]; i++)
{
    int number = int.Parse(Console.ReadLine());
    secondSet.Add(number);
}

var intersect = firstSet.Intersect(secondSet);

foreach (var item in intersect)
{
    Console.Write(item + " ");
}