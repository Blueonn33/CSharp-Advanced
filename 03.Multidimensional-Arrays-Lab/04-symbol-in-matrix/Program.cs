int size = int.Parse(Console.ReadLine());

char[,] matrix = ReadMatrix(size, size);

char symbol = char.Parse(Console.ReadLine());
int foundRow = 0;
int foundCol = 0;
bool found = false;

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] == symbol)
        {
            foundRow = row;
            foundCol = col;
            found = true;
            Console.WriteLine($"({foundRow}, {foundCol})");
            break;
        }
    }

    if (found)
    {
        break;
    }
}

if (!found)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}

static char[,] ReadMatrix(int rows, int cols)
{
    char[,] matrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string currentRow = Console.ReadLine();

        for (int col = 0; col < cols; col++)
        {
            char value = currentRow[col];
            matrix[row, col] = value;
        }
    }

    return matrix;
}