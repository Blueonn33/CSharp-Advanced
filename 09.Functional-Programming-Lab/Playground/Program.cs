class Program
{
    private static int number = 0;
    static void Main(string[] args)
    {
        var result = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(n => n % 2 == 0)
            .ToList();

        var numbers = new int[]{ 4, 3, 2, 2, 4, 56, 32, 4 };
        var filtered = numbers
            .Where(Filter)
            .ToList();
    }

    static bool Filter(int number)
    {
        return number > 2;
    }

    static bool OddNumbers(int number)
    {
        return number % 2 != 0;
    }

    static int Sum(int first, int second)
    {
        return first + second;
    }
}
