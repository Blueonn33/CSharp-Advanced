int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

string command = Console.ReadLine();

while (command != "end")
{
    Func<int, int> manipulator = null;

    switch (command)
    {
        case "add":
            manipulator = x => x + 1;
            break;
        case "subtract":
            manipulator = x => x - 1;
            break;
        case "multiply":
            manipulator = x => x * 2;
            break;
        case "print":
            Console.WriteLine(string.Join(" ", array));
            break;
    }

    if (manipulator != null)
    {
        ManipulateArray(array, manipulator);
    }

    command = Console.ReadLine();
}

void ManipulateArray(int[] array, Func<int, int> manipulator)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = manipulator(array[i]);
    }
}