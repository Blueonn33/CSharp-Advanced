int[] matrixDimensions = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixDimensions[0];
int cols = matrixDimensions[1];
int maxSum = 0;
string maxSumSquare = "";

int[,] matrix = ReadMatrix(rows, cols);

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        int currentSum = matrix[row, col] +
                         matrix[row, col + 1] +
                         matrix[row + 1, col] +
                         matrix[row + 1, col + 1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxSumSquare = $"{matrix[row, col]} {matrix[row, col + 1]}\n{matrix[row + 1, col]} {matrix[row + 1, col + 1]}";
        }
    }
}

Console.WriteLine(maxSumSquare);
Console.WriteLine(maxSum);


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