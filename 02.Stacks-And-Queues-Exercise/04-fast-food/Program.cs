namespace _04_fast_food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());

            int[] ordersInput = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            Queue<int> orders = new(ordersInput);

            int maxOrder = orders.Max();

            while (orders.Count > 0)
            {
                int order = orders.Peek();

                if (order <= foodAmount)
                {
                    foodAmount -= order;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(maxOrder);

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.Write(string.Join(" ", orders));
            }
        }
    }
}
