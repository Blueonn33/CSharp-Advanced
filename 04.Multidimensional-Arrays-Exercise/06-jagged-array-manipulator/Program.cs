int rows = int.Parse(Console.ReadLine());

var jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    var currentRow = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    jaggedArray[row] = currentRow;
}

for (int row = 0; row < rows - 1; row++)
{
    var currentRowLength = jaggedArray[row].Length;
    var nextRowLength = jaggedArray[row + 1].Length;

    if (currentRowLength == nextRowLength)
    {
        Multiply(jaggedArray[row]);
        Multiply(jaggedArray[row + 1]);
    }
    else
    {
        Divide(jaggedArray[row]);
        Divide(jaggedArray[row + 1]);
    }
}

while (true)
{
    var command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    if (command.StartsWith("Add") || command.StartsWith("Subtract"))
    {
        var parts = command.Split();
        var row = int.Parse(parts[1]);
        var col = int.Parse(parts[2]);
        var value = int.Parse(parts[3]);

        if (row >= 0 && row < jaggedArray.Length 
                     && col >= 0 
                     && col < jaggedArray[row].Length)
        {
            if (parts[0] == "Add")
            {
                jaggedArray[row][col] += value;
            }
            else
            {
                jaggedArray[row][col] -= value;
            }
        }
    }
}

for (int row = 0; row < rows; row++)
{
    Console.WriteLine(string.Join(" ", jaggedArray[row]));
}

static void Multiply(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= 2;
    }
}

static void Divide(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] /= 2;
    }
}