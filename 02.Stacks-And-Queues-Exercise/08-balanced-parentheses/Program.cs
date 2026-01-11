namespace _08_balanced_parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] expression = Console.ReadLine().ToCharArray();

            Stack<char> openBrackets = new();
            bool isBalanced = false;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(' || expression[i] == '{' || expression[i] == '[')
                {
                    openBrackets.Push(expression[i]);
                }
                else
                {
                    isBalanced = true;

                    if (openBrackets.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    char openBracket = openBrackets.Pop();

                    switch (expression[i])
                    {
                        case ')':
                            if (openBracket != '(')
                            {
                                isBalanced = false;
                            }

                            break;
                        case '}':
                            if (openBracket != '{')
                            {
                                isBalanced = false;
                            }

                            break;
                        case ']':
                            if (openBracket != '[')
                            {
                                isBalanced = false;
                            }

                            break;
                    }

                    if (!isBalanced)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}
