int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

static int Sum(int[] array, int index)
{
    if (index == array.Length)
        return 0;

    return array[index] + Sum(array, index + 1);
}


Console.WriteLine(Sum(array,0));