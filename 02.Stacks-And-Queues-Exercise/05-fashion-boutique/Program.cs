namespace _05_fashion_boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int capacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int sum = 0;

            Stack<int> stack = new(clothes);

            while (stack.Count > 0)
            {
                int cloth = stack.Peek();
                sum += cloth;

                if (sum <= capacity)
                {
                    stack.Pop();

                    if (stack.Count == 0)
                    {
                        racks++;
                    }
                }
                else if(sum > capacity)
                {
                    racks++;
                    sum = 0;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
