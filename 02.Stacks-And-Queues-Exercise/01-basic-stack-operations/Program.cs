namespace _01_basic_stack_operations
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
            int pop = numbers[1];
            int check = numbers[2];

            Stack<int> stack = new();

            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < count; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(check))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
