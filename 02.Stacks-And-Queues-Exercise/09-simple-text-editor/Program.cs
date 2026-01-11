namespace _09_simple_text_editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = "";

            Stack<string> stack = new();

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                string[] input = command.Split();

                string action = input[0];

                switch (action)
                {
                    case "1":
                        string text = input[1];
                        stack.Push(text);
                        break;

                    case "2":
                        int remove = int.Parse(input[1]);
                        string removeText = stack.Peek();

                        if (removeText.Length == remove)
                        {
                            stack.Push("");
                        }
                        else
                        {
                            int length = removeText.Length - remove;
                            removeText = removeText.Substring(0, length);
                            stack.Push(removeText);
                        }

                        break;

                    case "3":
                        int index = int.Parse(input[1]) - 1;
                        string indexText = stack.Peek();

                        Console.WriteLine(indexText[index]);
                        break;

                    case "4":
                        stack.Pop();
                        break;
                }
            }
        }
    }
}
