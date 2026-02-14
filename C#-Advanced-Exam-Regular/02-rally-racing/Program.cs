using System.Data;
using System.Net.WebSockets;

int size = int.Parse(Console.ReadLine());
string carNumber = Console.ReadLine();
char[,] matrix = new char[size, size];

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
    string[] input = Console.ReadLine().Split(' ');

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        char symbol = char.Parse(input[col]);
        matrix[row, col] = symbol;

        if (symbol == 'T')
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

        if (symbol == 'F')
        {
            finishRow = row;
            finishCol = col;
        }
    }
}

string command = Console.ReadLine();

while (command != "End")
{
    // int initialRow = startRow;
    // int initialCol = startCol;

    if (matrix[startRow, startCol] == 'T')
    {
        matrix[startRow, startCol] = '.';

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

        matrix[startRow, startCol] = '.';
        totalKilometers += 20;
    }
    if (matrix[startRow, startCol] == 'F')
    {
        break;
    }

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

    command = Console.ReadLine();
}

static void PrintMatrix(char[,] matrix, int startRow, int startCol)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (row == startRow && col == startCol)
            {
                matrix[row, col] = 'C';
            }

            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }
}

static bool IsValidCoordinates(char[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0) &&
           col >= 0 && col < matrix.GetLength(1);
}

if (matrix[startRow, startCol] != matrix[finishRow, finishCol])
{
    Console.WriteLine($"Racing car {carNumber} DNF.");
}
else
{
    Console.WriteLine($"Racing car {carNumber} finished the stage!");
}

Console.WriteLine($"Distance covered {totalKilometers} km.");
PrintMatrix(matrix, startRow, startCol);
