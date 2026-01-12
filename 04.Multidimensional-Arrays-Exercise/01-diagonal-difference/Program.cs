int size = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[size, size];
matrix = ReadMatrix(size);

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int row = 0, row1 = size - 1; row < size; row++, row1--)
{
    primaryDiagonalSum += matrix[row, row];
    secondaryDiagonalSum += matrix[row1, row];
}

int result = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

Console.WriteLine(result);

static int[,] ReadMatrix(int size)
{
    int[,] matrix = new int[size, size];

    for (int row = 0; row < size; row++)
    {
        int[] rowData = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < size; col++)
        {
            matrix[row, col] = rowData[col];
        }
    }

    return matrix;
}