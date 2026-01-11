namespace _07_truck_tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int smallestIndex = Int32.MaxValue;

            Queue<int> stations = new();
            Queue<int> distances = new();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

                stations.Enqueue(input[0]);
                distances.Enqueue(input[1]);
            }

            for (int i = 0; i < n; i++)
            {
                if (stations.Peek() >= distances.Peek())
                {
                    if (smallestIndex > i)
                    {
                        smallestIndex = i;
                        stations.Dequeue();
                        distances.Dequeue();
                    }
                }
                else
                {
                    int station = stations.Dequeue();
                    stations.Enqueue(station);

                    int distance = distances.Dequeue();
                    distances.Enqueue(distance);
                }
            }

            Console.WriteLine(smallestIndex);
        }
    }
}
