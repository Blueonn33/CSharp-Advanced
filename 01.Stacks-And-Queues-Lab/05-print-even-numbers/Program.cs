namespace _05_print_even_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new(numbers);
            Queue<int> evenNumbers = new();

            foreach (var item in queue)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Enqueue(item);
                }
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
