namespace _03_maximum_and_minimum_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new();
            string command = "";

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                string[] parts = command.Split();
                string numberCommand = parts[0];

                switch (numberCommand)
                {
                    case "1":
                        int numberToPush = int.Parse(parts[1]);
                        stack.Push(numberToPush);
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":

                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }

                        break;
                    case "4":

                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }

                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
