int dimension = int.Parse(Console.ReadLine());

int[,] matrix = ReadMatrix(dimension, dimension);
Console.WriteLine(PrimaryDiagonalSum(matrix));

static int PrimaryDiagonalSum(int[,] matrix)
{
    int sum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        sum += matrix[row, row];
    }

    return sum;
}

static int[,] ReadMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

    return matrix;
}