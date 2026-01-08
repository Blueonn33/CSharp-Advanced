namespace _01_reverse_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new();

            foreach (char c in input)
            {
                stack.Push(c);
            }

            foreach (var c in stack)
            {
                Console.Write(c);
            }
        }
    }
}
