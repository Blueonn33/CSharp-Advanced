namespace CustomComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(array, new NumbersComparer());

            Console.WriteLine(string.Join(" ", array));
        }
    }

    class NumbersComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0)
            {
                if (y % 2 == 0)
                {
                    return x.CompareTo(y);
                }

                return -1;
            }
            else
            {
                if (y % 2 == 0)
                {
                    return 1;
                }

                return x.CompareTo(y);
            }
        }
    }
}
