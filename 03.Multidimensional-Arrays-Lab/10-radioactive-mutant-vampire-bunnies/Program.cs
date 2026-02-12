int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

char[,] lair = new char[rows, cols];
int playerRow = -1;
int playerCol = -1;

for (int row = 0; row < rows; row++)
{
    var currentRow = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        lair[row, col] = currentRow[col];

        if (currentRow[col] == 'P')
        {
            playerRow = row;
            playerCol = col;
            lair[row, col] = '.';
        }
    }
}

string commands = Console.ReadLine();

foreach (var command in commands)
{
    var lastPlayerRow = playerRow;
    var lastPlayerCol = playerCol;

    // Move the player according to the command 
    if (command == 'L')
    {
        playerCol--;
    }
    else if (command == 'R')
    {
        playerCol++;
    }
    else if (command == 'U')
    {
        playerRow--;
    }
    else if (command == 'D')
    {
        playerRow++;
    }

    // Multiply the bunnies

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (lair[row, col] == 'B')
            {
                if (ValidCoordinates(lair, row - 1, col) &&
                    lair[row - 1, col] == '.')
                {
                    lair[row - 1, col] = 'b';
                }
                if (ValidCoordinates(lair, row + 1, col) &&
                    lair[row + 1, col] == '.')
                {
                    lair[row + 1, col] = 'b';
                }
                if (ValidCoordinates(lair, row, col - 1) &&
                    lair[row, col - 1] == '.')
                {
                    lair[row, col - 1] = 'b';
                }
                if (ValidCoordinates(lair, row, col + 1) &&
                    lair[row, col + 1] == '.')
                {
                    lair[row, col + 1] = 'b';
                }
            }
        }
    }

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (lair[row, col] == 'b')
            {
                lair[row, col] = 'B';
            }
        }
    }

    // Check if the player is still in the lair

    if (ValidCoordinates(lair, playerRow, playerCol))
    {
        // Check if the player has been caught by a bunny
        if (lair[playerRow, playerCol] == 'B')
        {
            // Dead
            PrintMatrix(lair);
            Console.WriteLine($"dead: {playerRow} {playerCol}");
            return;
        }
    }
    else
    {
        // Win
        PrintMatrix(lair);
        Console.WriteLine($"won: {lastPlayerRow} {lastPlayerCol}");
        return;
    }
}

static bool ValidCoordinates(char[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0) &&
           col >= 0 && col < matrix.GetLength(1);
}

static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }
}