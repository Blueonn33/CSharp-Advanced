namespace _07_hot_potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();

            Queue<string> queue = new(kids);
            int passes = int.Parse(Console.ReadLine());
            int tosses = 1;

            while (queue.Count > 1)
            {
                string kid = queue.Dequeue();

                if (tosses == passes)
                {
                    tosses = 1;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    queue.Enqueue(kid);
                    tosses++;
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
