using System.Data;

int size = int.Parse(Console.ReadLine());
string carNumber = Console.ReadLine();
string[,] matrix = new string[size, size];

int startRow = 0;
int startCol = 0;
int firstTunnelRow = 0;
int firstTunnelCol = 0;
int secondTunnelRow = 0;
int secondTunnelCol = 0;
int finishRow = 0;
int finishCol = 0;
bool firstTunnel = true;

int totalKilometers = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
    {
        string input = Console.ReadLine();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = input[col];

            if (input[col] == "T")
            {
                if (firstTunnel)
                {
                    firstTunnelRow = row;
                    firstTunnelCol = col;
                    firstTunnel = false;
                }
                else
                {
                    secondTunnelRow = row;
                    secondTunnelCol = col;
                }
            }

            if (input[col] == "F")
            {
                finishRow = row;
                finishCol = col;
            }
        }
    }

string command = Console.ReadLine();

while (command != "End" && matrix[startRow, startCol] != matrix[finishRow, finishCol])
{
    // int initialRow = startRow;
    // int initialCol = startCol;

    if (command == "up")
    {
        // startRow--;

        if (IsValidCoordinates(matrix, startRow - 1, startCol))
        {
            startRow--;
            totalKilometers += 10;
            // startRow = initialRow;
            // startCol = initialCol;
        }
    }
    else if (command == "down")
    {
        if (IsValidCoordinates(matrix, startRow + 1, startCol))
        {
            startRow++;
            totalKilometers += 10;
        }
    }
    else if (command == "left")
    {
        if (IsValidCoordinates(matrix, startRow, startCol - 1))
        {
            startCol--;
            totalKilometers += 10;
        }
    }
    else if (command == "right")
    {
        if (IsValidCoordinates(matrix, startRow, startCol + 1))
        {
            startCol++;
            totalKilometers += 10;
        }
    }

    if (matrix[startRow, startCol] == "T")
    {
        matrix[startRow, startCol] = ".";

        if (startRow == firstTunnelRow)
        {
            startRow = secondTunnelRow;
            startCol = secondTunnelCol;
        }
        else
        {
            startRow = firstTunnelRow;
            startCol = firstTunnelCol;
        }

        matrix[startRow, startCol] = ".";
        totalKilometers += 30;
    }

    command = Console.ReadLine();
}

static void PrintMatrix (string[,] matrix)
{
    for (int row = 0; row < matrix.GetLengt(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (matrix[row, col] == matrix[startRow, startCol])
            {
                matrix[row, col] = "C";
            }

            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }
}

static bool IsValidCoordinates(string[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0) &&
           col >= 0 && col < matrix.GetLength(1);
}

Console.WriteLine($"Racing car {carNumber} finished the stage!");
Console.WriteLine($"Distance covered {totalKilometers} km.");
PrintMatrix(matrix);