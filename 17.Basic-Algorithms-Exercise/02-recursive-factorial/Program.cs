int n = int.Parse(Console.ReadLine());

static long Factorial(int n)
{
    if (n == 0)
        return 1;

    return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(n));
