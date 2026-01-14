int size = int.Parse(Console.ReadLine());

var matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    var currentRow = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = currentRow[col];
    }
}

var bombsInput = Console.ReadLine()
    .Split();

foreach (var bomb in bombsInput)
{
    var bombParts = bomb.Split(',');

    int bombRow = int.Parse(bombParts[0]);
    int bombCol = int.Parse(bombParts[1]);
    int bombValue = matrix[bombRow, bombCol];

    if (bombValue > 0)
    {
        Explode(matrix, bombRow - 1, bombCol - 1, bombValue);
        Explode(matrix, bombRow - 1, bombCol, bombValue);
        Explode(matrix, bombRow - 1, bombCol + 1, bombValue);
        Explode(matrix, bombRow, bombCol - 1, bombValue);
        Explode(matrix, bombRow, bombCol + 1, bombValue);
        Explode(matrix, bombRow, bombCol, bombValue);
        Explode(matrix, bombRow + 1, bombCol - 1, bombValue);
        Explode(matrix, bombRow + 1, bombCol, bombValue);
        Explode(matrix, bombRow + 1, bombCol + 1, bombValue);
        Explode(matrix, bombRow, bombCol, bombValue);
    }
}

int aliveCells = 0;
int aliveCellsSum = 0;

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] > 0)
        {
            aliveCells++;
            aliveCellsSum += matrix[row, col];
        }
    }
}

Console.WriteLine("Alive cells: " + aliveCells);
Console.WriteLine("Sum: " + aliveCellsSum);

for (int row = 0; row < size; row++)
{

    for (int col = 0; col < size; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }

    Console.WriteLine();
}

static void Explode(int[,] matrix, int row, int col, int value)
{
    if (CoodinatesValid(matrix, row, col))
    {
        if (matrix[row, col] > 0)
        {
            matrix[row, col] -= value;
        }
    }
}

static bool CoodinatesValid(int[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0) &&
           col >= 0 && col < matrix.GetLength(1);
}