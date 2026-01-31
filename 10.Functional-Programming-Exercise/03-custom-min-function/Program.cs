Func<int[], int> smallestFunc = FindSmallestNumber;

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int FindSmallestNumber(int[] array)
{
    int min = int.MaxValue;

    foreach (int item in array)
    {
        if (item < min)
        {
            min = item;
        }
    }

    return min;
}