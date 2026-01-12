int[] size = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] rowData = Console.ReadLine()!
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowData[col];
    }
}

while (true)
{
    var command = Console.ReadLine();

    if (command == "END")
    {
        break;
    }

    if (command.StartsWith("swap"))
    {
        var commandParts = command
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (commandParts.Length != 5)
        {
            Console.WriteLine("Invalid input!");
            continue;
        }

        int row1 = int.Parse(commandParts[1]);
        int col1 = int.Parse(commandParts[2]);
        int row2 = int.Parse(commandParts[3]);
        int col2 = int.Parse(commandParts[4]);

        if (row1 < 0 || row1 >= rows || col1 < 0 || col1 >= cols ||
            row2 < 0 || row2 >= rows || col2 < 0 || col2 >= cols)
        {
            Console.WriteLine("Invalid input!");
            continue;
        }

        (matrix[row2, col2], matrix[row1, col1]) = (matrix[row1, col1], matrix[row2, col2]);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}