using System.Runtime.InteropServices.Marshalling;

int[] sizes = ReadIntegerArray();

int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] values = ReadIntegerArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}

if (rows < 3 || cols < 3)
{
    Console.WriteLine("Sum = 0");
}
else
{
    int maxSum = 0;
    int maxRow = 0;
    int maxCol = 0;

    for (int row = 0; row < rows - 2; row++)
    {
        for (int col = 0; col < cols - 2; col++)
        {
            var sum = SumCube(matrix, row, col);

            if (sum > maxSum)
            {
                maxSum = sum;
                maxRow = row;
                maxCol = col;
            }
        }
    }

    Console.WriteLine($"Sum = {maxSum}");

    for (int row = maxRow; row < maxRow + 3; row++)
    {
        for (int col = maxCol; col < maxCol + 3; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}

static int SumCube(int[,] matrix, int currentRow, int currentCol)
{
    int sum = 0;

    for (int row = currentRow; row < currentRow + 3; row++)
    {
        for (int col = currentCol; col < currentCol + 3; col++)
        {
            sum += matrix[row, col];
        }
    }

    return sum;
}

static int[] ReadIntegerArray()
{
    return Console.ReadLine()
        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}