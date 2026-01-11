namespace _09_simple_text_editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> states = new();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                   .Split();
                string current = "";

                if (states.Count > 0)
                {
                    current = states.Peek();
                }

                switch (command[0])
                {
                    case "1":
                        current += command[1];
                        states.Push(current);
                        break;
                    case "2":
                        int count = int.Parse(command[1]);
                        current = current.Remove(current.Length - count, count);
                        states.Push(current);
                        break;
                    case "3":
                        int index = int.Parse(command[1]) - 1;
                        Console.WriteLine(current[index]);
                        break;
                    case "4":
                        if (states.Count > 0)
                        {
                            states.Pop();
                        }
                        break;
                }
            }
        }
    }
}
