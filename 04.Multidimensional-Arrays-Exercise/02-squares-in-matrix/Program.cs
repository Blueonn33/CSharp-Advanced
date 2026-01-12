int[] input = Console.ReadLine()!
    .Split()
    .Select(int.Parse)
    .ToArray();

int rows = input[0];
int cols = input[1];

if (rows < 2 || cols < 2)
{
    Console.WriteLine(0);
}
else
{
    string[,] matrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] symbols = Console.ReadLine()
            .Split()
            .ToArray();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = symbols[col];
        }
    }

    int counter = 0;

    for (int row = 0; row < rows - 1; row++)
    {
        for (int col = 0; col < cols - 1; col++)
        {
            bool found = matrix[row, col] ==
                         matrix[row, col + 1] &&
                         matrix[row, col] ==
                         matrix[row + 1, col] &&
                         matrix[row, col] ==
                         matrix[row + 1, col + 1];

            if (found)
            {
                counter++;
            }
        }
    }

    Console.WriteLine(counter);
}
