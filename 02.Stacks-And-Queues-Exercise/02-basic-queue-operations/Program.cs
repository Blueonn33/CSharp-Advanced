namespace _02_basic_queue_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = numbers[0];
            int enqueue = numbers[1];
            int check = numbers[2];

            Queue<int> queue = new();

            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < enqueue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(check))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
