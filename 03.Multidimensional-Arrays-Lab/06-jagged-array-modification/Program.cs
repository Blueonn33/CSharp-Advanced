int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];


for (int row = 0; row < rows; row++)
{
    int[] currentRow = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    jaggedArray[row] = currentRow;
}

while (true)
{
    string command = Console.ReadLine();

    if (command == "END")
    {
        break;
    }

    if (command.StartsWith("Add"))
    {
        var parts = command.Split();

        int row = int.Parse(parts[1]);
        int col = int.Parse(parts[2]);
        int value = int.Parse(parts[3]);

        if (!ValidCoordinates(jaggedArray, row, col))
        {
            Console.WriteLine("Invalid coordinates");
            continue;
        }

        jaggedArray[row][col] += value;
    }
    if (command.StartsWith("Subtract"))
    {
        var parts = command.Split();

        int row = int.Parse(parts[1]);
        int col = int.Parse(parts[2]);
        int value = int.Parse(parts[3]);

        if (!ValidCoordinates(jaggedArray, row, col))
        {
            Console.WriteLine("Invalid coordinates");
            continue;
        }

        jaggedArray[row][col] -= value;
    }
}

PrintJaggedArray(jaggedArray);

static void PrintJaggedArray(int[][] jaggedArray)
{
    for (int row = 0; row < jaggedArray.Length; row++)
    {
        Console.WriteLine(string.Join(" ", jaggedArray[row]));
    }
}

static bool ValidCoordinates(int[][] jaggedArray, int row, int col)
{
    if (row >= jaggedArray.Length || row < 0)
    {
        return false;
    }

    if (col >= jaggedArray[row].Length || col < 0)
    {
        return false;
    }

    return true;
}