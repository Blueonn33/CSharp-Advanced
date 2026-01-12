int size = int.Parse(Console.ReadLine());

long[][] pascalTriangle = new long[size][];

pascalTriangle[0] = [1];

if (size > 1)
{
    pascalTriangle[1] = [1, 1];

    for (int row = 2; row < size; row++)
    {
        int colSize = row + 1;
        pascalTriangle[row] = new long[colSize];

        pascalTriangle[row][0] = 1;
        pascalTriangle[row][colSize - 1] = 1;

        for (int col = 1; col < colSize - 1; col++)
        {
            pascalTriangle[row][col] =
                pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
        }
    }
}

for (int row = 0; row < size; row++)
{
    Console.WriteLine(string.Join(" ", pascalTriangle[row]));
}