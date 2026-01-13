namespace _11_key_revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new(bulletsInput);
            Queue<int> locks = new(locksInput);

            int barrelCounter = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int bullet = bullets.Pop();
                int currentLock = locks.Peek();
                barrelCounter++;

                if (bullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (barrelCounter == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    barrelCounter = 0;
                }
            }

            if (bullets.Count >= 0 && locks.Count == 0)
            {
                int moneyEarned = intelligenceValue - (bulletPrice * (bulletsInput.Length - bullets.Count));

                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
