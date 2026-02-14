Stack<int> caffeine = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
Queue<int> energyDrinks = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

int totalCaffeine = 0;

while (totalCaffeine <= 300 && caffeine.Count > 0 && energyDrinks.Count > 0)
{
    int caffeineInput = caffeine.Pop();
    int energyDrinkInput = energyDrinks.Dequeue();
    int sum = caffeineInput * energyDrinkInput;

    if (totalCaffeine + sum <= 300)
    {
        totalCaffeine += sum;
    }
    else
    {
        if (totalCaffeine >= 30)
        {
            totalCaffeine -= 30;
        }

        energyDrinks.Enqueue(energyDrinkInput);
    }
}

if (energyDrinks.Count > 0)
{
    Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
}
else if (totalCaffeine <= 300)
{
    Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");