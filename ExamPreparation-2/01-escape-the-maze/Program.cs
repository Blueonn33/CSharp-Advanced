using System.Text;

Queue<int> times = new(Console.ReadLine().Split().Select(int.Parse));

Stack<int> tasks = new(Console.ReadLine().Split().Select(int.Parse));

int darthVaderDuckyCount = 0;
int thorDuckyCount = 0;
int bigBlueDuckyCount = 0;
int smallYellowDuckyCount = 0;

while (times.Count > 0)
{
    int time = times.Dequeue();
    int task = tasks.Pop();

    int taskTime = time * task;

    if (taskTime <= 60)
    {
        darthVaderDuckyCount++;
    }
    else if (taskTime <= 120)
    {
        thorDuckyCount++;
    }
    else if (taskTime <= 180)
    {
        bigBlueDuckyCount++;
    }
    else if (taskTime <= 240)
    {
        smallYellowDuckyCount++;
    }
    else
    {
        times.Enqueue(time);
        tasks.Push(task - 2);
    }
}

StringBuilder sb = new StringBuilder();
sb.AppendLine($"Congratulations, all tasks have been completed! Rubber ducks rewarded:");
sb.AppendLine($"Darth Vader Ducky: {darthVaderDuckyCount}");
sb.AppendLine($"Thor Ducky: {thorDuckyCount}");
sb.AppendLine($"Big Blue Rubber Ducky: {bigBlueDuckyCount}");
sb.AppendLine($"Small Yellow Rubber Ducky: {smallYellowDuckyCount}");

Console.WriteLine(sb.ToString().TrimEnd());
