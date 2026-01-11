int[] matrixDimensions = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixDimensions[0];
int cols = matrixDimensions[1];

int[,] matrix = ReadMatrix(rows, cols);
int sum = MatrixSum(matrix);

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);

static int MatrixSum(int[,] matrix)
{
    int sum = 0;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            sum += matrix[row, col];
        }
    }

    return sum;
}

static int[,] ReadMatrix(int rows, int cols)
{
    var matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] currentRow = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = currentRow[col];
        }
    }

    return matrix;
}