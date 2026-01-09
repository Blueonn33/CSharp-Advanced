namespace _03_simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> stack = new(input);

            int result = int.Parse(stack.Pop());

            while (stack.Count > 1)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    result += number;
                }
                else if (operation == "-")
                {
                    result -= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}
