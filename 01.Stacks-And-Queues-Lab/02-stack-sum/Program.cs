namespace _02_stack_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();

            int[] numbers = command
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new(numbers);

            while (command != "end")
            {
                string[] splitted = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("add"))
                {
                    int firstNum = int.Parse(splitted[1]);
                    int secondNum = int.Parse(splitted[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }

                if (command.Contains("remove"))
                {
                    int size = int.Parse(splitted[1]);

                    if (size <= stack.Count)
                    {
                        while (size > 0)
                        {
                            stack.Pop();
                            size--;
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
