namespace _04_matching_brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> openingBracketsIndex = new();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBracketsIndex.Push(i);
                }

                if (expression[i] == ')')
                {
                    int openIndex = openingBracketsIndex.Pop();
                    string subExpression = expression.Substring(openIndex, i - openIndex + 1);
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
