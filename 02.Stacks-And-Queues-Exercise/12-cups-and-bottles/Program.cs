namespace _12_cups_and_bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] bottlesInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int wastedWater = 0;

            Queue<int> cups = new(cupsInput);
            Stack<int> bottles = new(bottlesInput);

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Dequeue();
                int currentBottle = bottles.Pop();

                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                }
                else
                {
                    currentCup -= currentBottle;

                    while (currentCup > 0 && bottles.Count > 0)
                    {
                        if (bottles.Peek() >= currentCup)
                        {
                            wastedWater += bottles.Pop() - currentCup;
                            currentCup = 0;
                        }
                        else
                        {
                            currentCup -= bottles.Pop();
                        }
                    }
                }
            }

            Console.WriteLine(cups.Count == 0
                ? $"Bottles: {string.Join(" ", bottles)}"
                : $"Cups: {string.Join(" ", cups)}");

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
