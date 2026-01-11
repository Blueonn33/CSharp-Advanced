namespace _07_truck_tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new();

            for (int i = 0; i < n; i++)
            {
                int[] pump = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

                pumps.Enqueue(pump); 
            }

            int pumpPosition = 0;

            while (pumps.Count > 0)
            {
                int currentFuel = 0;
                bool isPathValid = true;

                foreach (var pump in pumps)
                {
                    currentFuel += pump[0];
                    currentFuel -= pump[1];

                    if (currentFuel < 0)
                    {
                        pumps.Dequeue();
                        pumpPosition++;
                        isPathValid = false;
                        break;
                    }
                }

                if (isPathValid)
                {
                    break;
                }
            }

            Console.WriteLine(pumpPosition);
        }
    }
}
